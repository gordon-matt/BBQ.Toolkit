using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

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

        public string Group => "Images";

        public string SubGroup => null;

        public Image Icon => Properties.Resources.Shapes;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}