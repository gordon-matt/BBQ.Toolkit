using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.RegexStudio.Controls
{
    public class MatchTreeView : TreeView
    {
        public event GroupChangedEventHandler GroupChanged;
        public event MatchChangedEventHandler MatchChanged;

        public void AddMatch(Regex regex, Match match)
        {
            TreeNode node = new TreeNode(match.Value);
            node.Tag = match;
            for (int i = 1; i < match.Groups.Count; i++)
            {
                TreeNode node2 = new TreeNode(regex.GroupNameFromNumber(i));
                node2.Tag = match.Groups[i];
                node.Nodes.Add(node2);
            }
            base.Nodes.Add(node);
        }

        protected override void OnAfterSelect(TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                if (this.MatchChanged != null)
                {
                    MatchChangedEventArgs args = new MatchChangedEventArgs();
                    args.Match = e.Node.Tag as Match;
                    this.MatchChanged(args);
                }
            }
            else if ((e.Node.Level == 1) && (this.GroupChanged != null))
            {
                GroupChangedEventArgs args2 = new GroupChangedEventArgs();
                args2.Group = e.Node.Tag as Group;
                this.GroupChanged(args2);
            }
            base.OnAfterSelect(e);
        }

        public delegate void GroupChangedEventHandler(GroupChangedEventArgs e);
        public delegate void MatchChangedEventHandler(MatchChangedEventArgs e);
    }

    public class GroupChangedEventArgs
    {
        public Group Group { get; set; }
    }
    public class MatchChangedEventArgs
    {
        public Match Match { get; set; }
    }
}