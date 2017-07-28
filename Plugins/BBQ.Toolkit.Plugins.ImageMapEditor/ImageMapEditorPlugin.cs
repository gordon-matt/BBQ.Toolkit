using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using BBQ.Toolkit.Common;
using System.Drawing;

namespace BBQ.Toolkit.Plugins.ImageMapEditor
{
    [Export(typeof(IPlugin))]
    public class ImageMapEditorPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content
        {
            get { return new Main(); }
        }

        #endregion

        #region IPlugin Members

        public string Title
        {
            get { return "Image Map Editor"; }
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string Group
        {
            get { return "Images"; }
        }

        public string SubGroup
        {
            get { return null; }
        }

        public Image Icon
        {
            get { return Properties.Resources.Shapes; }
        }

        public ISettingsControl SettingsControl
        {
            get { return null; }
        }

        #endregion
    }
}
