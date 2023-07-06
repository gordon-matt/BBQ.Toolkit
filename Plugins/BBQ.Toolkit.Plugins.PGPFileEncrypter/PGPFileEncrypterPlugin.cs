using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;

namespace BBQ.Toolkit.Plugins.PGPFileEncrypter;

[Export(typeof(IPlugin))]
public class PGPFileEncrypterPlugin : IUserControlPlugin
{
    public string Title => "PGP File Encrypter";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Security;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}