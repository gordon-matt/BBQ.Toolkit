using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    partial class HotSpotInputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new Krypton.Toolkit.KryptonLabel();
            this.txtUrl = new Krypton.Toolkit.KryptonTextBox();
            this.txtAlt = new Krypton.Toolkit.KryptonTextBox();
            this.lblAlt = new Krypton.Toolkit.KryptonLabel();
            this.btnOK = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(12, 9);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 20);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Values.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(70, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(282, 23);
            this.txtUrl.TabIndex = 1;
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(70, 35);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(282, 23);
            this.txtAlt.TabIndex = 2;
            // 
            // lblAlt
            // 
            this.lblAlt.Location = new System.Drawing.Point(12, 38);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(52, 20);
            this.lblAlt.TabIndex = 3;
            this.lblAlt.Values.Text = "Alt Text";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(222, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(62, 30);
            this.btnOK.TabIndex = 7;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // HotSpotInputDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 105);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotSpotInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotSpot info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonLabel lblUrl;
        private KryptonTextBox txtUrl;
        private KryptonTextBox txtAlt;
        private KryptonLabel lblAlt;
        private KryptonButton btnOK;
        private KryptonButton btnCancel;
    }
}