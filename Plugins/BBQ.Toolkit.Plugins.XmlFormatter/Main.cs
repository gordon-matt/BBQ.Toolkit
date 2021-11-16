using System;
using System.IO;
using System.Windows.Forms;
using Extenso;
using Extenso.IO;

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
                txtXml.Text = new FileInfo(dlgOpenFile.FileName).ReadAllText();
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            txtXml.Text = XmlHelper.PrettyPrint(txtXml.Text);
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