using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.RegexStudio
{
    [Export(typeof(IPlugin))]
    public class RegexStudioPlugin : IUserControlPlugin
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
            get { return "Regex Studio"; }
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string Group
        {
            get { return "Text"; }
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