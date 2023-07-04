using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Plugins.ImageMapEditor.Properties;

namespace BBQ.Toolkit.Plugins.ImageMapEditor
{
    [Export(typeof(IPlugin))]
    public class ImageMapEditorPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "Image Map Editor";

        public string Description => string.Empty;

        public string Group => CommonConstants.PluginCategories.Images;

        public string SubGroup => null;

        public Image Icon => Resources.Icon;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}