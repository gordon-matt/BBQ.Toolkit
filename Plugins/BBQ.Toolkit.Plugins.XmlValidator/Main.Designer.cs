using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.XmlValidator
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
            btnLoadXml = new System.Windows.Forms.ToolStripButton();
            btnLoadXsd = new System.Windows.Forms.ToolStripButton();
            btnValidate = new System.Windows.Forms.ToolStripButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
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
            panelTop.Size = new System.Drawing.Size(798, 40);
            panelTop.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnLoadXml, btnLoadXsd, btnValidate });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(798, 39);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "kryptonToolStrip1";
            // 
            // btnLoadXml
            // 
            btnLoadXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLoadXml.Image = Properties.Resources.Xml;
            btnLoadXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadXml.Name = "btnLoadXml";
            btnLoadXml.Size = new System.Drawing.Size(36, 36);
            btnLoadXml.Text = "Load XML";
            btnLoadXml.Click += btnXML_Click;
            // 
            // btnLoadXsd
            // 
            btnLoadXsd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLoadXsd.Image = Properties.Resources.Xsd;
            btnLoadXsd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadXsd.Name = "btnLoadXsd";
            btnLoadXsd.Size = new System.Drawing.Size(36, 36);
            btnLoadXsd.Text = "Load XSD";
            btnLoadXsd.Click += btnXSD_Click;
            // 
            // btnValidate
            // 
            btnValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnValidate.Image = Properties.Resources.Validate;
            btnValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new System.Drawing.Size(36, 36);
            btnValidate.Text = "Validate";
            btnValidate.Click += btnValidate_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "XML Files|*.xml|XSD Files|*.xsd|All Files|*.*";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(txtXml, 0, 0);
            tableLayoutPanel.Controls.Add(txtXsd, 1, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(798, 528);
            tableLayoutPanel.TabIndex = 1;
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
            txtXml.Location = new System.Drawing.Point(3, 3);
            txtXml.Name = "txtXml";
            txtXml.Paddings = new System.Windows.Forms.Padding(0);
            txtXml.RightBracket = '>';
            txtXml.RightBracket2 = ')';
            txtXml.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            txtXml.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtXml.ServiceColors");
            txtXml.Size = new System.Drawing.Size(393, 522);
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
            txtXsd.Size = new System.Drawing.Size(393, 522);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnLoadXml;
        private System.Windows.Forms.ToolStripButton btnLoadXsd;
        private System.Windows.Forms.ToolStripButton btnValidate;
        private FastColoredTextBoxNS.FastColoredTextBox txtXml;
        private FastColoredTextBoxNS.FastColoredTextBox txtXsd;
    }
}
