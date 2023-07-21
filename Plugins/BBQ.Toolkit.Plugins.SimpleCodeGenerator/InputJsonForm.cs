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
        var sb = new StringBuilder();
        sb.AppendLine("Access each JSON property via the 'Model' object.");
        Data = txtData.Text.StartsWith("[") ? JArray.Parse(txtData.Text) : JArray.Parse($"[{txtData.Text}]");
        ModelStructure = sb.ToString();

        //sb.AppendLine("Properties for each item in 'Model' are as follows: ");
        //var schema = JsonSchema.Parse(txtData.Text);

        //if (schema.Type == JsonSchemaType.Array)
        //{
        //    ModelStructure = GetJArrayProperties(schema, 0);
        //}
        //else if (schema.Type == JsonSchemaType.Object)
        //{
        //    ModelStructure = GetJObjectProperties(schema, 0);
        //}

        Close();
    }

    //private string GetJArrayProperties(JsonSchema schema, int level)
    //{
    //    var sb = new StringBuilder();
    //    foreach (var item in schema.Items.Where(x => x.Type.HasValue && x.Type == JsonSchemaType.Object))
    //    {
    //        sb.AppendLine(GetJObjectProperties(schema, level + 1));
    //    }
    //    return sb.ToString();
    //}

    //private string GetJObjectProperties(JsonSchema schema, int level)
    //{
    //    var sb = new StringBuilder();

    //    foreach (var property in schema.Properties)
    //    {
    //        switch (property.Value.Type)
    //        {
    //            case JsonSchemaType.Array:
    //                sb.AppendLine(GetJArrayProperties(property.Value, level + 1));
    //                break;
    //            case JsonSchemaType.Object:
    //                sb.AppendLine(property.Key);
    //                sb.AppendLine(GetJObjectProperties(property.Value, level + 1));
    //                break;
    //            default: sb.AppendLine($"{new string(' ', 4 * level)} {property.Key}");
    //                break;
    //        }
    //    }

    //    return sb.ToString();
    //}
}