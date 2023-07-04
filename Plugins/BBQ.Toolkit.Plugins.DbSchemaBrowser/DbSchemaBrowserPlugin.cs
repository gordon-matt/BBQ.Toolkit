﻿using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using BBQ.Toolkit.Plugins.DbSchemaBrowser.Properties;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser
{
    [Export(typeof(IPlugin))]
    public class DbSchemaBrowserPlugin : IUserControlPlugin
    {
        #region IUserControlPlugin Members

        public UserControl Content => new Main();

        #endregion IUserControlPlugin Members

        #region IPlugin Members

        public string Title => "Db Schema Browser";

        public string Description => "View Sql Metadata";

        public string Group => CommonConstants.PluginCategories.Data;

        public string SubGroup => null;

        public Image Icon => Resources.Icon;

        public ISettingsControl SettingsControl => null;

        #endregion IPlugin Members
    }
}