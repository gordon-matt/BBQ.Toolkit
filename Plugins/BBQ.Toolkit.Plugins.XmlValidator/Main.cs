using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Extenso;
using Extenso.IO;

namespace BBQ.Toolkit.Plugins.XmlValidator
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            Xml =
@"<?xml version=""1.0""?>
<x:books xmlns:x=""urn:books"">
   <book id=""bk001"">
      <author>Writer</author>
      <title>The First Book</title>
      <genre>Fiction</genre>
      <price>44.95</price>
      <pub_date>2000-10-01</pub_date>
      <review>An amazing story of nothing.</review>
   </book>

   <book id=""bk002"">
      <author>Poet</author>
      <title>The Poet's First Poem</title>
      <genre>Poem</genre>
      <price>24.95</price>
      <review>Least poetic poems.</review>
   </book>
</x:books>";

            Xsd =
    @"<xsd:schema xmlns:xsd=""http://www.w3.org/2001/XMLSchema""
            targetNamespace=""urn:books""
            xmlns:bks=""urn:books"">

  <xsd:element name=""books"" type=""bks:BooksForm""/>

  <xsd:complexType name=""BooksForm"">
    <xsd:sequence>
      <xsd:element name=""book"" 
                  type=""bks:BookForm"" 
                  minOccurs=""0"" 
                  maxOccurs=""unbounded""/>
      </xsd:sequence>
  </xsd:complexType>

  <xsd:complexType name=""BookForm"">
    <xsd:sequence>
      <xsd:element name=""author""   type=""xsd:string""/>
      <xsd:element name=""title""    type=""xsd:string""/>
      <xsd:element name=""genre""    type=""xsd:string""/>
      <xsd:element name=""price""    type=""xsd:float"" />
      <xsd:element name=""pub_date"" type=""xsd:date"" />
      <xsd:element name=""review""   type=""xsd:string""/>
    </xsd:sequence>
    <xsd:attribute name=""id""   type=""xsd:string""/>
  </xsd:complexType>
</xsd:schema>";

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

        private string xsdPath;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnXML_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                Xml = new FileInfo(dlgOpenFile.FileName).ReadAllText();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnXSD_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                xsdPath = dlgOpenFile.FileName;
                Xsd = new FileInfo(xsdPath).ReadAllText();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(xsdPath) && !string.IsNullOrEmpty(Xsd))
                {
                    string tempFile = Path.GetTempFileName();
                    Xsd.ToFile(tempFile);
                    xsdPath = tempFile;
                }

                var xDoc = XDocument.Parse(Xml);
                var schemaSet = new XmlSchemaSet();
                string @namespace = "http://mynamespace.example.com"; // TODO
                schemaSet.Add(@namespace, xsdPath);
                xDoc.Validate(schemaSet, null);

                MessageBox.Show("Schema is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}