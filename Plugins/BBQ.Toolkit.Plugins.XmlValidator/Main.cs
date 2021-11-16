using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Extenso.IO;

namespace BBQ.Toolkit.Plugins.XmlValidator
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private string xml;
        private string xsdPath;

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                xml = new FileInfo(dlgOpenFile.FileName).ReadAllText();
            }
        }

        private void btnXSD_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                xsdPath = dlgOpenFile.FileName;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                var xDoc = XDocument.Parse(xml);
                var schemaSet = new XmlSchemaSet();
                string @namespace = "http://mynamespace.example.com";
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