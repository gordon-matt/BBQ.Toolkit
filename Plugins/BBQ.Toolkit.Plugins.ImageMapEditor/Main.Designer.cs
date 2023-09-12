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
            if (disposing)
            {
                image?.Dispose();
                pen?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tsBtnRectangle = new System.Windows.Forms.ToolStripButton();
            tsBtnCircle = new System.Windows.Forms.ToolStripButton();
            toolStrip = new KryptonToolStrip();
            tsBtnOpen = new System.Windows.Forms.ToolStripButton();
            tsBtnPolygon = new System.Windows.Forms.ToolStripButton();
            pictureBox = new System.Windows.Forms.PictureBox();
            txtHtml = new KryptonTextBox();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tsBtnRectangle
            // 
            tsBtnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnRectangle.Image = Properties.Resources.Rectangle;
            tsBtnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnRectangle.Name = "tsBtnRectangle";
            tsBtnRectangle.Size = new System.Drawing.Size(36, 36);
            tsBtnRectangle.Text = "Rectangle";
            tsBtnRectangle.Click += tsBtnRectangle_Click;
            // 
            // tsBtnCircle
            // 
            tsBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnCircle.Image = Properties.Resources.Circle;
            tsBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnCircle.Name = "tsBtnCircle";
            tsBtnCircle.Size = new System.Drawing.Size(36, 36);
            tsBtnCircle.Text = "Circle";
            tsBtnCircle.Click += tsBtnCircle_Click;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsBtnOpen, tsBtnRectangle, tsBtnCircle, tsBtnPolygon });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(913, 39);
            toolStrip.TabIndex = 25;
            toolStrip.Text = "toolStrip1";
            // 
            // tsBtnOpen
            // 
            tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnOpen.Image = (System.Drawing.Image)resources.GetObject("tsBtnOpen.Image");
            tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnOpen.Name = "tsBtnOpen";
            tsBtnOpen.Size = new System.Drawing.Size(36, 36);
            tsBtnOpen.Text = "Open Image";
            tsBtnOpen.Click += tsBtnOpen_Click;
            // 
            // tsBtnPolygon
            // 
            tsBtnPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnPolygon.Image = Properties.Resources.Polygon;
            tsBtnPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnPolygon.Name = "tsBtnPolygon";
            tsBtnPolygon.Size = new System.Drawing.Size(36, 36);
            tsBtnPolygon.Text = "Polygon";
            tsBtnPolygon.Click += tsBtnPolygon_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox.Location = new System.Drawing.Point(0, 39);
            pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(913, 432);
            pictureBox.TabIndex = 23;
            pictureBox.TabStop = false;
            // 
            // txtHtml
            // 
            txtHtml.Dock = System.Windows.Forms.DockStyle.Bottom;
            txtHtml.Location = new System.Drawing.Point(0, 471);
            txtHtml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtHtml.Multiline = true;
            txtHtml.Name = "txtHtml";
            txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtHtml.Size = new System.Drawing.Size(913, 136);
            txtHtml.TabIndex = 24;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBox);
            Controls.Add(toolStrip);
            Controls.Add(txtHtml);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(913, 607);
            Load += Main_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsBtnRectangle;
        private System.Windows.Forms.ToolStripButton tsBtnCircle;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnPolygon;
        private System.Windows.Forms.PictureBox pictureBox;
        private KryptonTextBox txtHtml;
        private System.Windows.Forms.ToolStripButton tsBtnOpen;
    }
}
