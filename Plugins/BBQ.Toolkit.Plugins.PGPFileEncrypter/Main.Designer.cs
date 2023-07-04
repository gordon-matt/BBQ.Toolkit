using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.PGPFileEncrypter
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnBrowseFile = new Krypton.Toolkit.KryptonButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFile = new Krypton.Toolkit.KryptonLabel();
            this.lblPublicKeyFile = new Krypton.Toolkit.KryptonLabel();
            this.txtFile = new Krypton.Toolkit.KryptonTextBox();
            this.txtPublicKeyFile = new Krypton.Toolkit.KryptonTextBox();
            this.btnBrowsePublicKeyFile = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = -1F;
            this.btnSave.Location = new System.Drawing.Point(422, 164);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Values.Text = "Encrypt and Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.CornerRoundingRadius = -1F;
            this.btnBrowseFile.Location = new System.Drawing.Point(116, 43);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Values.Text = "Browse";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "All Files|*.*";
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(22, 17);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(88, 20);
            this.lblFile.TabIndex = 3;
            this.lblFile.Values.Text = "File to Encrypt";
            // 
            // lblPublicKeyFile
            // 
            this.lblPublicKeyFile.Location = new System.Drawing.Point(22, 92);
            this.lblPublicKeyFile.Name = "lblPublicKeyFile";
            this.lblPublicKeyFile.Size = new System.Drawing.Size(88, 20);
            this.lblPublicKeyFile.TabIndex = 4;
            this.lblPublicKeyFile.Values.Text = "Public Key File";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(116, 14);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(512, 23);
            this.txtFile.TabIndex = 5;
            // 
            // txtPublicKeyFile
            // 
            this.txtPublicKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublicKeyFile.Location = new System.Drawing.Point(116, 89);
            this.txtPublicKeyFile.Name = "txtPublicKeyFile";
            this.txtPublicKeyFile.Size = new System.Drawing.Size(512, 23);
            this.txtPublicKeyFile.TabIndex = 6;
            // 
            // btnBrowsePublicKeyFile
            // 
            this.btnBrowsePublicKeyFile.CornerRoundingRadius = -1F;
            this.btnBrowsePublicKeyFile.Location = new System.Drawing.Point(116, 118);
            this.btnBrowsePublicKeyFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowsePublicKeyFile.Name = "btnBrowsePublicKeyFile";
            this.btnBrowsePublicKeyFile.Size = new System.Drawing.Size(104, 40);
            this.btnBrowsePublicKeyFile.TabIndex = 7;
            this.btnBrowsePublicKeyFile.Values.Text = "Browse";
            this.btnBrowsePublicKeyFile.Click += new System.EventHandler(this.btnBrowsePublicKeyFile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnBrowsePublicKeyFile);
            this.Controls.Add(this.txtPublicKeyFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblPublicKeyFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseFile);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(642, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KryptonButton btnSave;
        private KryptonButton btnBrowseFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private KryptonLabel lblFile;
        private KryptonLabel lblPublicKeyFile;
        private KryptonTextBox txtFile;
        private KryptonTextBox txtPublicKeyFile;
        private KryptonButton btnBrowsePublicKeyFile;
    }
}
