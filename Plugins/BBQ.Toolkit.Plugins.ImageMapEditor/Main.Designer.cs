using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor
{
    partial class Main
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

            pen.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsBtnRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new KryptonToolStrip();
            this.tsBtnPolygon = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtHtml = new Krypton.Toolkit.KryptonTextBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBtnRectangle
            // 
            this.tsBtnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRectangle.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Rectangle;
            this.tsBtnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRectangle.Name = "tsBtnRectangle";
            this.tsBtnRectangle.Size = new System.Drawing.Size(36, 36);
            this.tsBtnRectangle.Text = "Rectangle";
            this.tsBtnRectangle.Click += new System.EventHandler(this.tsBtnRectangle_Click);
            // 
            // tsBtnCircle
            // 
            this.tsBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCircle.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Circle;
            this.tsBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCircle.Name = "tsBtnCircle";
            this.tsBtnCircle.Size = new System.Drawing.Size(36, 36);
            this.tsBtnCircle.Text = "Circle";
            this.tsBtnCircle.Click += new System.EventHandler(this.tsBtnCircle_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRectangle,
            this.tsBtnCircle,
            this.tsBtnPolygon});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(783, 39);
            this.toolStrip.TabIndex = 25;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsBtnPolygon
            // 
            this.tsBtnPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPolygon.Image = global::BBQ.Toolkit.Plugins.ImageMapEditor.Properties.Resources.Polygon;
            this.tsBtnPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPolygon.Name = "tsBtnPolygon";
            this.tsBtnPolygon.Size = new System.Drawing.Size(36, 36);
            this.tsBtnPolygon.Text = "Polygon";
            this.tsBtnPolygon.Click += new System.EventHandler(this.tsBtnPolygon_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(783, 369);
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // txtHtml
            // 
            this.txtHtml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtHtml.Location = new System.Drawing.Point(0, 408);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtml.Size = new System.Drawing.Size(783, 118);
            this.txtHtml.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.txtHtml);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(783, 526);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsBtnRectangle;
        private System.Windows.Forms.ToolStripButton tsBtnCircle;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnPolygon;
        private System.Windows.Forms.PictureBox pictureBox;
        private KryptonTextBox txtHtml;

    }
}
