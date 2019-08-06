using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.FileDiffOutput
{
    [Export(typeof(IPlugin))]
    public class FileDiffOutputPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "File Diff Output";

        public string Description => string.Empty;

        public string Group => "Text";

        public string SubGroup => null;

        public Image Icon => null;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}