﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BBQ.Toolkit.Common;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using System.Drawing;

namespace BBQ.Toolkit.Plugins.FileDiffOutput
{
    [Export(typeof(IPlugin))]
    public class FileDiffOutputPlugin : IUserControlPlugin
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
            get { return "File Diff Output"; }
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