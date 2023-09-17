using BBQ.Toolkit.Common.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

public partial class InputJsonForm : Form, IDataInputForm<JArray>
{
    public InputJsonForm()
    {
        InitializeComponent();
        btnOK.Values.Image = CommonImages.OK_32x32;
        btnCancel.Values.Image = CommonImages.Cancel_32x32;
    }

    public string ModelStructure { get; private set; }

    public JArray Data { get; private set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            Data = txtData.Text.StartsWith("[") ? JArray.Parse(txtData.Text) : JArray.Parse($"[{txtData.Text}]");

            var sb = new StringBuilder();
            sb.AppendLine("'Model' is ALWAYS an array, even when the provided data is a single object. Nested arrays are suffixed with '[]', but should be accessed without that suffix.");
            sb.AppendLine();
            sb.AppendLine("The following JSON properties can be accessed via the objects in the 'Model' array:");
            sb.AppendLine();

            var structure = JsonHelper.GetStructure(txtData.Text);
            foreach (var item in structure)
            {
                sb.AppendLine(item);
            }

            ModelStructure = sb.ToString();

            Close();
        }
        catch (Exception x)
        {
            MessageBox.Show(x.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DialogResult = DialogResult.None;
        }
    }
}