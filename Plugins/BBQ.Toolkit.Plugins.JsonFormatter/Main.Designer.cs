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
            this.panelTop = new Krypton.Toolkit.KryptonPanel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnFormat = new Krypton.Toolkit.KryptonButton();
            this.btnLoad = new Krypton.Toolkit.KryptonButton();
            this.txtJson = new Krypton.Toolkit.KryptonTextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnFormat);
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 45);
            this.panelTop.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(104, 7);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(88, 32);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Values.Text = "Format";
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(9, 7);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 32);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Values.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(0, 45);
            this.txtJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(798, 523);
            this.txtJson.TabIndex = 1;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "JSON Files|*.json";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "JSON Files|*.json";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(798, 568);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonPanel panelTop;
        private KryptonTextBox txtJson;
        private KryptonButton btnSave;
        private KryptonButton btnFormat;
        private KryptonButton btnLoad;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}
