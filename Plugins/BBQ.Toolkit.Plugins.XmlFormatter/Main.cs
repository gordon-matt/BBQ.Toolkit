using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kore.IO;
using System.IO;
using Kore;

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
                txtXml.Text = new FileInfo(dlgOpenFile.FileName).GetText();
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
