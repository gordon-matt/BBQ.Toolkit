using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    partial class AddCircleForm
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
            this.lblXCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblXCoordinateValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new KryptonStatusStrip();
            this.lblYCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblYCoordinateValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRadius = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRadiusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new KryptonToolStrip();
            this.tsBtnRetry = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOK = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRadius = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblXCoordinate
            // 
            this.lblXCoordinate.Name = "lblXCoordinate";
            this.lblXCoordinate.Size = new System.Drawing.Size(15, 17);
            this.lblXCoordinate.Text = "x:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(159, 107);
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // lblXCoordinateValue
            // 
            this.lblXCoordinateValue.Name = "lblXCoordinateValue";
            this.lblXCoordinateValue.Size = new System.Drawing.Size(13, 17);
            this.lblXCoordinateValue.Text = "0";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblXCoordinate,
            this.lblXCoordinateValue,
            this.lblYCoordinate,
            this.lblYCoordinateValue,
            this.lblRadius,
            this.lblRadiusValue});
            this.statusStrip.Location = new System.Drawing.Point(0, 421);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(633, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblYCoordinate
            // 
            this.lblYCoordinate.Name = "lblYCoordinate";
            this.lblYCoordinate.Size = new System.Drawing.Size(16, 17);
            this.lblYCoordinate.Text = "y:";
            // 
            // lblYCoordinateValue
            // 
            this.lblYCoordinateValue.Name = "lblYCoordinateValue";
            this.lblYCoordinateValue.Size = new System.Drawing.Size(13, 17);
            this.lblYCoordinateValue.Text = "0";
            // 
            // lblRadius
            // 
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(42, 17);
            this.lblRadius.Text = "Radius";
            // 
            // lblRadiusValue
            // 
            this.lblRadiusValue.Name = "lblRadiusValue";
            this.lblRadiusValue.Size = new System.Drawing.Size(13, 17);
            this.lblRadiusValue.Text = "0";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRetry,
            this.tsBtnOK,
            this.tsBtnCancel,
            this.tsBtnRadius});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(633, 39);
            this.toolStrip.TabIndex = 26;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsBtnRetry
            // 
            this.tsBtnRetry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRetry.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Refresh;
            this.tsBtnRetry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRetry.Name = "tsBtnRetry";
            this.tsBtnRetry.Size = new System.Drawing.Size(36, 36);
            this.tsBtnRetry.Text = "Retry";
            this.tsBtnRetry.Click += new System.EventHandler(this.tsBtnRetry_Click);
            // 
            // tsBtnOK
            // 
            this.tsBtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOK.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.OK;
            this.tsBtnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOK.Name = "tsBtnOK";
            this.tsBtnOK.Size = new System.Drawing.Size(36, 36);
            this.tsBtnOK.Text = "OK";
            this.tsBtnOK.Click += new System.EventHandler(this.tsBtnOK_Click);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Cancel;
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(36, 36);
            this.tsBtnCancel.Text = "Cancel";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // tsBtnRadius
            // 
            this.tsBtnRadius.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRadius.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Radius;
            this.tsBtnRadius.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRadius.Name = "tsBtnRadius";
            this.tsBtnRadius.Size = new System.Drawing.Size(36, 36);
            this.tsBtnRadius.Text = "Radius";
            this.tsBtnRadius.Click += new System.EventHandler(this.tsBtnRadius_Click);
            // 
            // AddCircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 443);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "AddCircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Circle";
            this.Load += new System.EventHandler(this.AddCircleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblXCoordinate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripStatusLabel lblXCoordinateValue;
        private KryptonStatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblYCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel lblYCoordinateValue;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnRetry;
        private System.Windows.Forms.ToolStripButton tsBtnOK;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnRadius;
        private System.Windows.Forms.ToolStripStatusLabel lblRadius;
        private System.Windows.Forms.ToolStripStatusLabel lblRadiusValue;
    }
}