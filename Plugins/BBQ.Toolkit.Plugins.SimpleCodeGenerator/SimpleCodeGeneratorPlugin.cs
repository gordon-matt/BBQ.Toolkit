using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;
using BBQ.Toolkit.Plugins.SimpleCodeGenerator.Properties;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

[Export(typeof(IPlugin))]
public class SimpleCodeGeneratorPlugin : IUserControlPlugin
{
    public string Title => "Simple Code Generator";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Code;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}