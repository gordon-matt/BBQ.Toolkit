using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.XmlFormatter
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelTop = new KryptonPanel();
            toolStrip = new KryptonToolStrip();
            btnLoad = new System.Windows.Forms.ToolStripButton();
            btnFormat = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            txtXml = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)panelTop).BeginInit();
            panelTop.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtXml).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(toolStrip);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(798, 39);
            panelTop.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnLoad, btnFormat, btnSave });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(798, 39);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "kryptonToolStrip1";
            // 
            // btnLoad
            // 
            btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLoad.Image = (System.Drawing.Image)resources.GetObject("btnLoad.Image");
            btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(36, 36);
            btnLoad.Text = "Load";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFormat
            // 
            btnFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnFormat.Image = (System.Drawing.Image)resources.GetObject("btnFormat.Image");
            btnFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new System.Drawing.Size(36, 36);
            btnFormat.Text = "Format";
            btnFormat.Click += btnFormat_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(36, 36);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "Xml Files|*.xml";
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.Filter = "Xml Files|*.xml";
            // 
            // txtXml
            // 
            txtXml.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            txtXml.AutoIndentCharsPatterns = "";
            txtXml.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            txtXml.BackBrush = null;
            txtXml.CharHeight = 14;
            txtXml.CharWidth = 8;
            txtXml.CommentPrefix = null;
            txtXml.DefaultMarkerSize = 8;
            txtXml.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
            txtXml.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtXml.IsReplaceMode = false;
            txtXml.Language = FastColoredTextBoxNS.Language.XML;
            txtXml.LeftBracket = '<';
            txtXml.LeftBracket2 = '(';
            txtXml.Location = new System.Drawing.Point(0, 39);
            txtXml.Name = "txtXml";
            txtXml.Paddings = new System.Windows.Forms.Padding(0);
            txtXml.RightBracket = '>';
            txtXml.RightBracket2 = ')';
            txtXml.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            txtXml.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtXml.ServiceColors");
            txtXml.Size = new System.Drawing.Size(798, 529);
            txtXml.TabIndex = 1;
            txtXml.Zoom = 100;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(txtXml);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(798, 568);
            ((System.ComponentModel.ISupportInitialize)panelTop).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtXml).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KryptonPanel panelTop;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnFormat;
        private System.Windows.Forms.ToolStripButton btnSave;
        private FastColoredTextBoxNS.FastColoredTextBox txtXml;
    }
}
