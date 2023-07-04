using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Plugins.XmlValidator.Properties;

namespace BBQ.Toolkit.Plugins.XmlValidator
{
    [Export(typeof(IPlugin))]
    public class XmlValidatorPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "XML Validator";

        public string Description => string.Empty;

        public string Group => CommonConstants.PluginCategories.Text;

        public string SubGroup => null;

        public Image Icon => Resources.Validate;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}