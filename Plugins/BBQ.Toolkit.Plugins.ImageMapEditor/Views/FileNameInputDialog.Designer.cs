using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    partial class FileNameInputDialog
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
            txtFileName = new KryptonTextBox();
            lblFileName = new KryptonLabel();
            btnBrowse = new KryptonButton();
            btnOK = new KryptonButton();
            btnCancel = new KryptonButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new System.Drawing.Point(94, 15);
            txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new System.Drawing.Size(484, 23);
            txtFileName.TabIndex = 3;
            // 
            // lblFileName
            // 
            lblFileName.Location = new System.Drawing.Point(10, 17);
            lblFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new System.Drawing.Size(65, 20);
            lblFileName.TabIndex = 2;
            lblFileName.Values.Text = "File Name";
            // 
            // btnBrowse
            // 
            btnBrowse.CornerRoundingRadius = -1F;
            btnBrowse.Location = new System.Drawing.Point(586, 7);
            btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(88, 39);
            btnBrowse.TabIndex = 4;
            btnBrowse.Values.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnOK
            // 
            btnOK.CornerRoundingRadius = -1F;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(94, 44);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(88, 39);
            btnOK.TabIndex = 5;
            btnOK.Values.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = -1F;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(188, 44);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 39);
            btnCancel.TabIndex = 6;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // FileNameInputDialog
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(687, 95);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(btnBrowse);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FileNameInputDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Please enter file name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonTextBox txtFileName;
        private KryptonLabel lblFileName;
        private KryptonButton btnBrowse;
        private KryptonButton btnOK;
        private KryptonButton btnCancel;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}