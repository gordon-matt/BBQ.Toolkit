using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                SelectedFileName = dlgOpenFile.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}