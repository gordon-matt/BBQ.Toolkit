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
            this.btnValidate = new Krypton.Toolkit.KryptonButton();
            this.btnXSD = new Krypton.Toolkit.KryptonButton();
            this.btnXML = new Krypton.Toolkit.KryptonButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnValidate);
            this.panelTop.Controls.Add(this.btnXSD);
            this.panelTop.Controls.Add(this.btnXML);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(684, 39);
            this.panelTop.TabIndex = 0;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(170, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 28);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Values.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnXSD
            // 
            this.btnXSD.Location = new System.Drawing.Point(89, 6);
            this.btnXSD.Name = "btnXSD";
            this.btnXSD.Size = new System.Drawing.Size(75, 28);
            this.btnXSD.TabIndex = 1;
            this.btnXSD.Values.Text = "Load XSD";
            this.btnXSD.Click += new System.EventHandler(this.btnXSD_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(8, 6);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(75, 28);
            this.btnXML.TabIndex = 0;
            this.btnXML.Values.Text = "Load XML";
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "XML Files|*.xml|XSD Files|*.xsd|All Files|*.*";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelTop);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(684, 492);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonPanel panelTop;
        private KryptonButton btnValidate;
        private KryptonButton btnXSD;
        private KryptonButton btnXML;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}
