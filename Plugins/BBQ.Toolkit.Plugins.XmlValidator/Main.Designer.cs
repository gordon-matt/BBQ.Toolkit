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
            this.panelTop = new Krypton.Toolkit.KryptonPanel();
            this.toolStrip = new Krypton.Toolkit.KryptonToolStrip();
            this.btnLoadXml = new System.Windows.Forms.ToolStripButton();
            this.btnLoadXsd = new System.Windows.Forms.ToolStripButton();
            this.btnValidate = new System.Windows.Forms.ToolStripButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtXsd = new Krypton.Toolkit.KryptonTextBox();
            this.txtXml = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.toolStrip);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 40);
            this.panelTop.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadXml,
            this.btnLoadXsd,
            this.btnValidate});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(798, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "kryptonToolStrip1";
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadXml.Image = global::BBQ.Toolkit.Plugins.XmlValidator.Properties.Resources.Xml;
            this.btnLoadXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(36, 36);
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnLoadXsd
            // 
            this.btnLoadXsd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadXsd.Image = global::BBQ.Toolkit.Plugins.XmlValidator.Properties.Resources.Xsd;
            this.btnLoadXsd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadXsd.Name = "btnLoadXsd";
            this.btnLoadXsd.Size = new System.Drawing.Size(36, 36);
            this.btnLoadXsd.Text = "Load XSD";
            this.btnLoadXsd.Click += new System.EventHandler(this.btnXSD_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnValidate.Image = global::BBQ.Toolkit.Plugins.XmlValidator.Properties.Resources.Validate;
            this.btnValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(36, 36);
            this.btnValidate.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "XML Files|*.xml|XSD Files|*.xsd|All Files|*.*";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.txtXsd, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtXml, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(798, 528);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // txtXsd
            // 
            this.txtXsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXsd.Location = new System.Drawing.Point(402, 3);
            this.txtXsd.Multiline = true;
            this.txtXsd.Name = "txtXsd";
            this.txtXsd.Size = new System.Drawing.Size(393, 522);
            this.txtXsd.TabIndex = 1;
            // 
            // txtXml
            // 
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXml.Location = new System.Drawing.Point(3, 3);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(393, 522);
            this.txtXml.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(798, 568);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonPanel panelTop;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private KryptonTextBox txtXsd;
        private KryptonTextBox txtXml;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnLoadXml;
        private System.Windows.Forms.ToolStripButton btnLoadXsd;
        private System.Windows.Forms.ToolStripButton btnValidate;
    }
}
