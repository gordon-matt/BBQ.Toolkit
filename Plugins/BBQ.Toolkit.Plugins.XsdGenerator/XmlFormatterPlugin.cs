using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;
using BBQ.Toolkit.Plugins.XsdGenerator.Properties;

namespace BBQ.Toolkit.Plugins.XsdGenerator;

[Export(typeof(IPlugin))]
public class XmlFormatterPlugin : IUserControlPlugin
{
    public string Title => "XSD Generator";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Text;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}