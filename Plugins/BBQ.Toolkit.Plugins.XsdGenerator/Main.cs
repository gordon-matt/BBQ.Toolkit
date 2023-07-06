using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using BBQ.Toolkit.Common.Properties;
using Extenso;

namespace BBQ.Toolkit.Plugins.XsdGenerator;

public partial class Main : UserControl
{
    public Main()
    {
        InitializeComponent();
        btnLoad.Image = CommonImages.OpenFolder_32x32;
        btnSave.Image = CommonImages.Save_32x32;
    }

    public string Xml
    {
        get { return txtXml.Text.Trim(); }
        set { txtXml.Text = value; }
    }

    public string Xsd
    {
        get { return txtXsd.Text.Trim(); }
        set { txtXsd.Text = value; }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (dlgOpenFile.ShowDialog() == DialogResult.OK)
        {
            Xml = File.ReadAllText(dlgOpenFile.FileName);

            using var reader = XmlReader.Create(dlgOpenFile.FileName);
            var schema = new XmlSchemaInference();
            var schemaSet = schema.InferSchema(reader);

            using var memoryStream = new MemoryStream();
            schemaSet.Schemas().OfType<XmlSchema>().First().Write(memoryStream);
            Xsd = Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
        {
            Xsd.ToFile(dlgSaveFile.FileName);
        }
    }
}