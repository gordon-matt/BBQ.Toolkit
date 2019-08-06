using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.LogFilter
{
    [Export(typeof(IPlugin))]
    public class LogFilterPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "Log Filter";

        public string Description => string.Empty;

        public string Group => "Text";

        public string SubGroup => null;

        public Image Icon => null;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}