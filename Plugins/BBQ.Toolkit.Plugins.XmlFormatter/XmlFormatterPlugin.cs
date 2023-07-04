using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Plugins.XmlFormatter.Properties;

namespace BBQ.Toolkit.Plugins.XmlFormatter
{
    [Export(typeof(IPlugin))]
    public class XmlFormatterPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "Xml Formatter";

        public string Description => string.Empty;

        public string Group => CommonConstants.PluginCategories.Text;

        public string SubGroup => null;

        public Image Icon => Resources.Icon;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}