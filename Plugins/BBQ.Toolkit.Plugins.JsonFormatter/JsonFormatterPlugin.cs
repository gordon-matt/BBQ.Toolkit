using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.XmlFormatter
{
    [Export(typeof(IPlugin))]
    public class JsonFormatterPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "JSON Formatter";

        public string Description => string.Empty;

        public string Group => "Text";

        public string SubGroup => null;

        public Image Icon => null;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}