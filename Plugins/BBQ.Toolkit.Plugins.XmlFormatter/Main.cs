using System;
using System.IO;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using Extenso;
using Extenso.IO;

namespace BBQ.Toolkit.Plugins.XmlFormatter
{
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
                txtXml.Text = new FileInfo(dlgOpenFile.FileName).ReadAllText();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnFormat_Click(object sender, EventArgs e)
        {
            txtXml.Text = XmlHelper.PrettyPrint(txtXml.Text);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                txtXml.Text.ToFile(dlgSaveFile.FileName);
            }
        }
    }
}