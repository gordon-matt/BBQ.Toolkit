using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Common.Forms;
using BBQ.Toolkit.Common.Plugins;
using BBQ.Toolkit.Plugins.ImageMapEditor.Properties;

namespace BBQ.Toolkit.Plugins.ImageMapEditor;

[Export(typeof(IPlugin))]
public class ImageMapEditorPlugin : IUserControlPlugin
{
    public string Title => "Image Map Editor";

    public string Description => string.Empty;

    public string Group => CommonConstants.PluginCategories.Images;

    public string SubGroup => null;

    public Image Icon => Resources.Icon;

    public ISettingsControl SettingsControl => null;

    public UserControl GetContent() => new Main();
}