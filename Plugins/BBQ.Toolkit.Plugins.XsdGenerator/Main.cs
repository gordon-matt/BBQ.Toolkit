using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using Kore;

namespace BBQ.Toolkit.Plugins.XsdGenerator
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                var reader = XmlReader.Create(dlgOpenFile.FileName);
                var schema = new XmlSchemaInference();
                var schemaSet = schema.InferSchema(reader);

                using (var memoryStream = new MemoryStream())
                {
                    schemaSet.Schemas().OfType<XmlSchema>().First().Write(memoryStream);
                    txtXml.Text = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                txtXml.Text.ToFile(dlgSaveFile.FileName);
            }
        }
    }
}