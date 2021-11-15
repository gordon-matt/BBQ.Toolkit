using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    partial class RadiusInputDialog
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
            this.lblRadius = new Krypton.Toolkit.KryptonLabel();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnOK = new Krypton.Toolkit.KryptonButton();
            this.nudRadius = new Krypton.Toolkit.KryptonNumericUpDown();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.Location = new System.Drawing.Point(12, 9);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(47, 20);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Values.Text = "Radius";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 37);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(122, 37);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(62, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(65, 9);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(187, 22);
            this.nudRadius.TabIndex = 4;
            this.nudRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RadiusInputDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(267, 80);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RadiusInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please enter radius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KryptonLabel lblRadius;
        private KryptonButton btnCancel;
        private KryptonButton btnOK;
        private KryptonNumericUpDown nudRadius;
    }
}