using System;
using System.IO;
using System.Windows.Forms;
using Extenso;
using Extenso.IO;
using Newtonsoft.Json;

namespace BBQ.Toolkit.Plugins.XmlFormatter
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
                txtJson.Text = new FileInfo(dlgOpenFile.FileName).ReadAllText();
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var obj = JsonConvert.DeserializeObject(txtJson.Text);
            txtJson.Text = JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                txtJson.Text.ToFile(dlgSaveFile.FileName);
            }
        }
    }
}