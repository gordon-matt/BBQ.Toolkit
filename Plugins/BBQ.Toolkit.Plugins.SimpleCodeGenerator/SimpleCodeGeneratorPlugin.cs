using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
{
    [Export(typeof(IPlugin))]
    public class SimpleCodeGeneratorPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "Simple Code Generator";

        public string Description => string.Empty;

        public string Group => "CodeGen";

        public string SubGroup => null;

        public Image Icon => null;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}