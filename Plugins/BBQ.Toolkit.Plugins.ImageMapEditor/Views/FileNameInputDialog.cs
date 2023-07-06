using System;
using System.Windows.Forms;
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