using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using BBQ.Toolkit.Common;
using System.Windows.Forms;
using System.Drawing;

namespace BBQ.Toolkit.Plugins.LogFilter
{
    [Export(typeof(IPlugin))]
    public class LogFilterPlugin : IUserControlPlugin
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
            get { return "Log Filter"; }
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string Group
        {
            get { return "Text"; }
        }

        public string SubGroup
        {
            get { return null; }
        }

        public Image Icon
        {
            get { return null; }
        }

        public ISettingsControl SettingsControl
        {
            get { return null; }
        }

        #endregion
    }
}
