using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;
using BBQ.Toolkit.Plugins.JsonFormatter;

namespace BBQ.Toolkit.Plugins.XmlFormatter;

[Export(typeof(IPlugin))]
public class JsonFormatterPlugin : IUserControlPlugin
{
    public string Title => "JSON Formatter";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Text;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}