namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
{
    partial class InputCsvForm
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
            btnCancel = new Krypton.Toolkit.KryptonButton();
            btnOK = new Krypton.Toolkit.KryptonButton();
            txtCsvFile = new Krypton.Toolkit.KryptonTextBox();
            lblCsvFile = new Krypton.Toolkit.KryptonLabel();
            btnBrowse = new Krypton.Toolkit.KryptonButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            grpInput = new System.Windows.Forms.GroupBox();
            grpOptions = new System.Windows.Forms.GroupBox();
            txtDelimiter = new Krypton.Toolkit.KryptonTextBox();
            lblDelimiter = new Krypton.Toolkit.KryptonLabel();
            cbHasHeaderRow = new Krypton.Toolkit.KryptonCheckBox();
            grpInput.SuspendLayout();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = -1F;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(468, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 54);
            btnCancel.TabIndex = 8;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.CornerRoundingRadius = -1F;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(632, 175);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(158, 54);
            btnOK.TabIndex = 7;
            btnOK.Values.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // txtCsvFile
            // 
            txtCsvFile.Location = new System.Drawing.Point(72, 29);
            txtCsvFile.Name = "txtCsvFile";
            txtCsvFile.Size = new System.Drawing.Size(645, 23);
            txtCsvFile.TabIndex = 9;
            // 
            // lblCsvFile
            // 
            lblCsvFile.Location = new System.Drawing.Point(6, 29);
            lblCsvFile.Name = "lblCsvFile";
            lblCsvFile.Size = new System.Drawing.Size(54, 20);
            lblCsvFile.TabIndex = 10;
            lblCsvFile.Values.Text = "CSV File";
            // 
            // btnBrowse
            // 
            btnBrowse.CornerRoundingRadius = -1F;
            btnBrowse.Location = new System.Drawing.Point(724, 22);
            btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(46, 40);
            btnBrowse.TabIndex = 11;
            btnBrowse.Values.Text = "";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "CSV Files|*.csv";
            // 
            // grpInput
            // 
            grpInput.Controls.Add(txtCsvFile);
            grpInput.Controls.Add(btnBrowse);
            grpInput.Controls.Add(lblCsvFile);
            grpInput.Location = new System.Drawing.Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new System.Drawing.Size(777, 77);
            grpInput.TabIndex = 12;
            grpInput.TabStop = false;
            grpInput.Text = "Input";
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(txtDelimiter);
            grpOptions.Controls.Add(lblDelimiter);
            grpOptions.Controls.Add(cbHasHeaderRow);
            grpOptions.Location = new System.Drawing.Point(12, 95);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new System.Drawing.Size(778, 74);
            grpOptions.TabIndex = 13;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // txtDelimiter
            // 
            txtDelimiter.Location = new System.Drawing.Point(72, 22);
            txtDelimiter.Name = "txtDelimiter";
            txtDelimiter.Size = new System.Drawing.Size(274, 23);
            txtDelimiter.TabIndex = 11;
            txtDelimiter.Text = ",";
            // 
            // lblDelimiter
            // 
            lblDelimiter.Location = new System.Drawing.Point(6, 22);
            lblDelimiter.Name = "lblDelimiter";
            lblDelimiter.Size = new System.Drawing.Size(60, 20);
            lblDelimiter.TabIndex = 12;
            lblDelimiter.Values.Text = "Delimiter";
            // 
            // cbHasHeaderRow
            // 
            cbHasHeaderRow.Checked = true;
            cbHasHeaderRow.CheckState = System.Windows.Forms.CheckState.Checked;
            cbHasHeaderRow.Location = new System.Drawing.Point(456, 22);
            cbHasHeaderRow.Name = "cbHasHeaderRow";
            cbHasHeaderRow.Size = new System.Drawing.Size(114, 20);
            cbHasHeaderRow.TabIndex = 0;
            cbHasHeaderRow.Values.Text = "Has Header Row";
            // 
            // InputCsvForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 243);
            Controls.Add(grpOptions);
            Controls.Add(grpInput);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "InputCsvForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Input CSV";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnOK;
        private Krypton.Toolkit.KryptonTextBox txtCsvFile;
        private Krypton.Toolkit.KryptonLabel lblCsvFile;
        private Krypton.Toolkit.KryptonButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOptions;
        private Krypton.Toolkit.KryptonCheckBox cbHasHeaderRow;
        private Krypton.Toolkit.KryptonTextBox txtDelimiter;
        private Krypton.Toolkit.KryptonLabel lblDelimiter;
    }
}