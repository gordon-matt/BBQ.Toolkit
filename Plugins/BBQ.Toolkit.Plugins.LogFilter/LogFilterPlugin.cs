using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;
using BBQ.Toolkit.Plugins.LogFilter.Properties;

namespace BBQ.Toolkit.Plugins.LogFilter;

[Export(typeof(IPlugin))]
public class LogFilterPlugin : IUserControlPlugin
{
    public string Title => "Log Filter";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Text;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}