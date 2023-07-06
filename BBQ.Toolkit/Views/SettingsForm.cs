using BBQ.Toolkit.Common.Forms;

namespace BBQ.Toolkit.Views;

public partial class SettingsForm : KryptonForm
{
    private readonly ImageList imageList = new();

    public SettingsForm()
    {
        InitializeComponent();

        Program.Plugins.OrderBy(p => p.Title).ForEach(pluginTreeView.AddSettingsControl);

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

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
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

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnOK_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();
}