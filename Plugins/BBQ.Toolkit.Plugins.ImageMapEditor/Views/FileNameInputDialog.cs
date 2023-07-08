using System;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class FileNameInputDialog : KryptonForm
    {
        public string SelectedFileName
        {
            get { return txtFileName.Text; }
            set { txtFileName.Text = value; }
        }

        public FileNameInputDialog()
        {
            InitializeComponent();
            btnBrowse.Values.Image = CommonImages.OpenFolder_32x32;
            btnOK.Values.Image = CommonImages.OK_32x32;
            btnCancel.Values.Image = CommonImages.Cancel_32x32;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                SelectedFileName = dlgOpenFile.FileName;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}