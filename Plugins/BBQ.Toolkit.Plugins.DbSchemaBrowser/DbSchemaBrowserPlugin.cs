using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser
{
    [Export(typeof(IPlugin))]
    public class DbSchemaBrowserPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content
        {
            get { return new Main(); }
        }

        #endregion

        #region IPlugin Members

        public string Title
        {
            get { return "Db Schema Browser"; }
        }

        public string Description
        {
            get { return "View Sql Metadata"; }
        }

        public string Group
        {
            get { return "Database"; }
        }

        public string SubGroup
        {
            get { return null; }
        }

        public Image Icon
        {
            get { return null; }
        }

        public ISettingsControl SettingsControl
        {
            get { return null; }
        }

        #endregion
    }
}
