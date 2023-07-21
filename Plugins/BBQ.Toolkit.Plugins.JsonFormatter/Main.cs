using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using Extenso;
using Extenso.IO;
using Newtonsoft.Json;

namespace BBQ.Toolkit.Plugins.XmlFormatter;

[ToolboxItem(false)]
public partial class Main : UserControl
{
    public Main()
    {
        InitializeComponent();
        btnLoad.Image = CommonImages.OpenFolder_32x32;
        btnFormat.Image = CommonImages.Clean_32x32;
        btnSave.Image = CommonImages.Save_32x32;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (dlgOpenFile.ShowDialog() == DialogResult.OK)
        {
            txtJson.Text = new FileInfo(dlgOpenFile.FileName).ReadAllText();
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnFormat_Click(object sender, EventArgs e)
    {
        var obj = JsonConvert.DeserializeObject(txtJson.Text);
        txtJson.Text = JsonConvert.SerializeObject(obj, Formatting.Indented);
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
        {
            txtJson.Text.ToFile(dlgSaveFile.FileName);
        }
    }
}