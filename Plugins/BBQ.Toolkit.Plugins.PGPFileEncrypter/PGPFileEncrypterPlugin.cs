using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.PGPFileEncrypter
{
    [Export(typeof(IPlugin))]
    public class PGPFileEncrypterPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "PGP File Encrypter";

        public string Description => string.Empty;

        public string Group => CommonConstants.PluginCategories.Security;

        public string SubGroup => null;

        public Image Icon => Resources.Icon;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}