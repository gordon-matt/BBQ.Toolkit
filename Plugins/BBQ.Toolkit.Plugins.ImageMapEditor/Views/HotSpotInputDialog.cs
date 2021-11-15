using System;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class HotSpotInputDialog : KryptonForm
    {
        public string Url
        {
            get { return txtUrl.Text; }
            set { txtUrl.Text = value; }
        }

        public string AlternateText
        {
            get { return txtAlt.Text; }
            set { txtAlt.Text = value; }
        }

        public HotSpotInputDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}