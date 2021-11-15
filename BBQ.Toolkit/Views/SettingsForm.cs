using System;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Common;
using Krypton.Toolkit;
using Kore.Collections;

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

            var settingsPlugin = e.Node.Tag as ISettingsControl;

            var control = settingsPlugin.ControlContent;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}