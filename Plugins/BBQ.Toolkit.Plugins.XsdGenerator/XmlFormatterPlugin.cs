using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Plugins.XsdGenerator.Properties;

namespace BBQ.Toolkit.Plugins.XsdGenerator
{
    [Export(typeof(IPlugin))]
    public class XmlFormatterPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "XSD Generator";

        public string Description => string.Empty;

        public string Group => CommonConstants.PluginCategories.Text;

        public string SubGroup => null;

        public Image Icon => Resources.Icon;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}