using BBQ.Toolkit.Common.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

public partial class InputStringsForm : Form, IDataInputForm<IEnumerable<string>>
{
    public InputStringsForm()
    {
        InitializeComponent();
        btnOK.Values.Image = CommonImages.OK_32x32;
        btnCancel.Values.Image = CommonImages.Cancel_32x32;
    }

    public string ModelStructure => @"Model // Just iterate over each item in 'Model'";

    public IEnumerable<string> Data { get; private set; } = Enumerable.Empty<string>();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnParse_Click(object sender, EventArgs e)
    {
        Data = txtData.Text
            .Trim()
            .Split(new[] { Environment.NewLine, "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim());

        lbItems.DataSource = Data.ToList();
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnOK_Click(object sender, EventArgs e) => Close();
}