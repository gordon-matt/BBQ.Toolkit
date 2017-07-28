using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

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
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
