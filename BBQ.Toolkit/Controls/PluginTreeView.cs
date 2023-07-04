namespace BBQ.Toolkit.Controls;

public class PluginTreeView : TreeView
{
    //TODO: Check same image not being added multiple times
    private readonly ImageList imageList = new ImageList();

    public Size ImageListImageSize
    {
        get { return imageList.ImageSize; }
        set { imageList.ImageSize = value; }
    }

    public PluginTreeView()
    {
        ImageList = imageList;
        imageList.Images.Add(Resources.TreeImage);
    }

    public void AddPlugin(IPlugin plugin)
    {
        #region Main Plugin Node

        var pluginItem = new TreeNode(plugin.Title)
        {
            Tag = plugin
        };

        if (plugin.Icon != null)
        {
            imageList.Images.Add(plugin.Icon);
            pluginItem.ImageIndex = imageList.Images.Count - 1;
            pluginItem.SelectedImageIndex = imageList.Images.Count - 1;
        }

        #endregion Main Plugin Node

        #region SubGroup

        TreeNode subGroup = null;
        try
        {
            if (!string.IsNullOrEmpty(plugin.SubGroup))
            {
                subGroup = new TreeNode(plugin.SubGroup);
                subGroup.Nodes.Add(pluginItem);
            }
        }
        catch (NotImplementedException)
        {
            // Do nothing (check for main group next)
        }

        #endregion SubGroup

        #region Group

        TreeNode group = null;
        try
        {
            if (!string.IsNullOrEmpty(plugin.Group))
            {
                group = new TreeNode(plugin.Group);

                if (subGroup != null)
                {
                    group.Nodes.Add(subGroup);
                }
                else { group.Nodes.Add(pluginItem); }
                //this.Nodes.Add(group);
                EnsureNode(group);
            }
        }
        catch (NotImplementedException)
        {
            if (subGroup != null)
            {
                Nodes.Add(subGroup);
            }
            else { Nodes.Add(pluginItem); }
            return;
        }

        #endregion Group

        if (group == null && subGroup == null)
        {
            Nodes.Add(pluginItem);
        }
    }

    public void AddSettingsControl(IPlugin plugin)
    {
        #region Main Plugin Node

        var pluginItem = new TreeNode(plugin.Title);
        pluginItem.Tag = plugin.SettingsControl;

        if (plugin.Icon != null)
        {
            imageList.Images.Add(plugin.Icon);
            pluginItem.ImageIndex = imageList.Images.Count - 1;
            pluginItem.SelectedImageIndex = imageList.Images.Count - 1;
        }

        #endregion Main Plugin Node

        #region SubGroup

        TreeNode subGroup = null;
        try
        {
            if (!string.IsNullOrEmpty(plugin.SubGroup))
            {
                subGroup = new TreeNode(plugin.SubGroup);
                subGroup.Nodes.Add(pluginItem);
            }
        }
        catch (NotImplementedException)
        {
            // Do nothing (check for main group next)
        }

        #endregion SubGroup

        #region Group

        TreeNode group = null;
        try
        {
            if (!string.IsNullOrEmpty(plugin.Group))
            {
                group = new TreeNode(plugin.Group);

                if (subGroup != null)
                {
                    group.Nodes.Add(subGroup);
                }
                else { group.Nodes.Add(pluginItem); }

                EnsureNode(group);
            }
        }
        catch (NotImplementedException)
        {
            if (subGroup != null)
            {
                Nodes.Add(subGroup);
            }
            else { Nodes.Add(pluginItem); }
            return;
        }

        #endregion Group

        if (group == null && subGroup == null)
        {
            Nodes.Add(pluginItem);
        }
    }

    private TreeNode EnsureNode(TreeNode treeNode)
    {
        var node = Nodes.Cast<TreeNode>().SingleOrDefault(x => x.Text == treeNode.Text);

        if (node == null)
        {
            Nodes.Add(treeNode);
            return treeNode;
        }
        else
        {
            foreach (TreeNode subNode in treeNode.Nodes)
            {
                node.Nodes.Add(subNode);
            }

            return node;
        }
    }
}