using System;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class RadiusInputDialog : KryptonForm
    {
        public int Radius
        {
            get { return (int)nudRadius.Value; }
            set { nudRadius.Value = value; }
        }

        public RadiusInputDialog()
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