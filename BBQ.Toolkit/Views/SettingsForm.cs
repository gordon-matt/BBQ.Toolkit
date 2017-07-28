using System;
using System.Linq;
using System.Windows.Forms;
using Kore.Collections;
using BBQ.Toolkit.Common;
using ComponentFactory.Krypton.Toolkit;

namespace BBQ.Toolkit.Views
{
    public partial class SettingsForm : KryptonForm
    {
        private ImageList imageList = new ImageList();

        public SettingsForm()
        {
            InitializeComponent();

            Program.Plugins.OrderBy(p => p.Title).ForEach(plugin =>
            {
                pluginTreeView.AddSettingsControl(plugin);
            });

            if (pluginTreeView.Nodes.Count == 0)
            {
                MessageBox.Show(
                    "None of the plugins have any settings to configure",
                    "No Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Dispose();
            }
        }

        private void pluginTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            { return; }

            ISettingsControl settingsPlugin = e.Node.Tag as ISettingsControl;

            UserControl control = settingsPlugin.ControlContent;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}