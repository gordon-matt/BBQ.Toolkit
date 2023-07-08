using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.XsdGenerator
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
            btnSave = new System.Windows.Forms.ToolStripButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            txtXml = new FastColoredTextBoxNS.FastColoredTextBox();
            txtXsd = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)panelTop).BeginInit();
            panelTop.SuspendLayout();
            toolStrip.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtXml).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtXsd).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(toolStrip);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(798, 45);
            panelTop.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnLoad, btnSave });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(798, 39);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "kryptonToolStrip1";
            // 
            // btnLoad
            // 
            btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLoad.Image = (System.Drawing.Image)resources.GetObject("btnLoad.Image");
            btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(36, 36);
            btnLoad.Text = "Load XML";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(36, 36);
            btnSave.Text = "Save XSD";
            btnSave.Click += btnSave_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "Xml Files|*.xml";
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.Filter = "Xsd Files|*.xsd";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(txtXml, 0, 0);
            tableLayoutPanel.Controls.Add(txtXsd, 1, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 45);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(798, 523);
            tableLayoutPanel.TabIndex = 2;
            // 
            // txtXml
            // 
            txtXml.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            txtXml.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtXml.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            txtXml.BackBrush = null;
            txtXml.CharHeight = 14;
            txtXml.CharWidth = 8;
            txtXml.DefaultMarkerSize = 8;
            txtXml.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
            txtXml.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtXml.IsReplaceMode = false;
            txtXml.Language = FastColoredTextBoxNS.Language.XML;
            txtXml.Location = new System.Drawing.Point(3, 3);
            txtXml.Name = "txtXml";
            txtXml.Paddings = new System.Windows.Forms.Padding(0);
            txtXml.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            txtXml.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtXml.ServiceColors");
            txtXml.Size = new System.Drawing.Size(393, 517);
            txtXml.TabIndex = 2;
            txtXml.Zoom = 100;
            // 
            // txtXsd
            // 
            txtXsd.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            txtXsd.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtXsd.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            txtXsd.BackBrush = null;
            txtXsd.CharHeight = 14;
            txtXsd.CharWidth = 8;
            txtXsd.DefaultMarkerSize = 8;
            txtXsd.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            txtXsd.Dock = System.Windows.Forms.DockStyle.Fill;
            txtXsd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtXsd.IsReplaceMode = false;
            txtXsd.Language = FastColoredTextBoxNS.Language.XML;
            txtXsd.Location = new System.Drawing.Point(402, 3);
            txtXsd.Name = "txtXsd";
            txtXsd.Paddings = new System.Windows.Forms.Padding(0);
            txtXsd.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            txtXsd.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtXsd.ServiceColors");
            txtXsd.Size = new System.Drawing.Size(393, 517);
            txtXsd.TabIndex = 3;
            txtXsd.Zoom = 100;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(798, 568);
            ((System.ComponentModel.ISupportInitialize)panelTop).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtXml).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtXsd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KryptonPanel panelTop;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private FastColoredTextBoxNS.FastColoredTextBox txtXml;
        private FastColoredTextBoxNS.FastColoredTextBox txtXsd;
    }
}
