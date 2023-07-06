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
            var node = new TreeNode(match.Value)
            {
                Tag = match
            };

            for (int i = 1; i < match.Groups.Count; i++)
            {
                node.Nodes.Add(new TreeNode(regex.GroupNameFromNumber(i))
                {
                    Tag = match.Groups[i]
                });
            }

            Nodes.Add(node);
        }

        protected override void OnAfterSelect(TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                MatchChanged?.Invoke(new MatchChangedEventArgs
                {
                    Match = e.Node.Tag as Match
                });
            }
            else if ((e.Node.Level == 1) && (GroupChanged != null))
            {
                GroupChanged(new GroupChangedEventArgs
                {
                    Group = e.Node.Tag as Group
                });
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