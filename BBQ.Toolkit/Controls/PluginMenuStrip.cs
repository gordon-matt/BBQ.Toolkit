using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Controls
{
    public class PluginMenuStrip : MenuStrip
    {
        private List<string> pluginItems = new List<string>();

        public void AddPlugin(IPlugin plugin)
        {
            #region Main Plugin Node

            var pluginItem = new ToolStripMenuItem(plugin.Title);
            pluginItem.Tag = plugin;

            try
            {
                if (plugin.Icon != null)
                {
                    pluginItem.Image = plugin.Icon;
                }
            }
            catch (NotImplementedException) { } // No icon

            if (plugin is IFormPlugin)
            {
                pluginItem.Click += new EventHandler(pluginItem_Click);
            }

            #endregion Main Plugin Node

            ToolStripMenuItem subGroup = null;
            try
            {
                if (!string.IsNullOrEmpty(plugin.SubGroup))
                {
                    subGroup = new ToolStripMenuItem(plugin.SubGroup);
                    subGroup.DropDownItems.Add(pluginItem);
                }
            }
            catch (NotImplementedException)
            {
                // Do nothing (check for main group next)
            }

            ToolStripMenuItem group = null;
            try
            {
                if (!string.IsNullOrEmpty(plugin.Group))
                {
                    group = new ToolStripMenuItem(plugin.Group);

                    if (subGroup != null)
                    {
                        group.DropDownItems.Add(subGroup);
                    }
                    else { group.DropDownItems.Add(pluginItem); }

                    EnsureItem(group);
                    pluginItems.Add(plugin.Group);
                }
            }
            catch (NotImplementedException)
            {
                if (subGroup != null)
                {
                    Items.Add(subGroup);
                    pluginItems.Add(plugin.SubGroup);
                }
                else
                {
                    Items.Add(pluginItem);
                    pluginItems.Add(plugin.Title);
                }
                return;
            }

            if (group == null && subGroup == null)
            {
                Items.Add(pluginItem);
                pluginItems.Add(plugin.Title);
            }
        }

        private ToolStripMenuItem EnsureItem(ToolStripMenuItem menuItem)
        {
            var item = this.Items.Cast<ToolStripMenuItem>().SingleOrDefault(x => x.Text == menuItem.Text);

            if (item == null)
            {
                Items.Add(menuItem);
                return menuItem;
            }
            else
            {
                foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
                {
                    item.DropDownItems.Add(subItem);
                }

                return item;
            }
        }

        public void RemovePlugins()
        {
            foreach (string item in pluginItems)
            {
                Items.RemoveByKey(item);
            }
        }

        private void pluginItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var plugin = menuItem.Tag as IFormPlugin;
            var form = plugin.Content;

            if (plugin.ShowAs == ShowAs.Dialog)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
        }
    }
}