using System;
using BBQ.Toolkit.Common.Properties;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser;

public partial class ConnectionStringDialog : KryptonForm
{
    public ConnectionStringDialog()
    {
        InitializeComponent();
        btnOK.Values.Image = CommonImages.OK_32x32;
        btnCancel.Values.Image = CommonImages.Cancel_32x32;
    }

    public string ConnectionString
    {
        get => txtInput.Text;
        set => txtInput.Text = value;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnOK_Click(object sender, EventArgs e) => Close();
}