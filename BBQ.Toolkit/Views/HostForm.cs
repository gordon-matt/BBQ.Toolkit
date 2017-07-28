using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using ComponentFactory.Krypton.Toolkit;

namespace BBQ.Toolkit.Views
{
    public partial class HostForm : KryptonForm
    {
        [ImportMany(typeof(IPlugin))]
        private IEnumerable<IPlugin> plugins = null;

        public HostForm()
        {
            InitializeComponent();

            using (AggregateCatalog aggregateCatalog = new AggregateCatalog(
                new AssemblyCatalog(typeof(Program).Assembly),
                new DirectoryCatalog(Path.Combine(Application.StartupPath, "Plugins"))))
            {
                using (CompositionContainer container = new CompositionContainer(aggregateCatalog))
                {
                    container.ComposeParts(this);
                }
            }

            Program.Plugins = this.plugins;
            this.plugins = null;

            foreach (IPlugin plugin in Program.Plugins)
            {
                pluginTreeView.AddPlugin(plugin);
            }
        }

        private void pluginTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            { return; }

            IPlugin plugin = e.Node.Tag as IPlugin;

            if (plugin is IUserControlPlugin)
            {
                UserControl control = ((IUserControlPlugin)plugin).Content;
                splitContainer.Panel2.Controls.Clear();
                splitContainer.Panel2.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }
            else if (plugin is IFormPlugin)
            {
                IFormPlugin formPlugin = (IFormPlugin)plugin;
                Form form = formPlugin.Content;

                if (formPlugin.ShowAs == ShowAs.Dialog)
                {
                    form.ShowDialog();
                }
                else
                {
                    form.Show();
                }
            }
        }

        private void mnuToolsPluginSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}