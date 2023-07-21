namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
{
    partial class InputJsonForm
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
            grpJSON = new System.Windows.Forms.GroupBox();
            txtData = new Krypton.Toolkit.KryptonTextBox();
            grpJSON.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = -1F;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(459, 507);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 54);
            btnCancel.TabIndex = 6;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.CornerRoundingRadius = -1F;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(629, 507);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(158, 54);
            btnOK.TabIndex = 5;
            btnOK.Values.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // grpJSON
            // 
            grpJSON.Controls.Add(txtData);
            grpJSON.Location = new System.Drawing.Point(12, 12);
            grpJSON.Name = "grpJSON";
            grpJSON.Size = new System.Drawing.Size(778, 489);
            grpJSON.TabIndex = 4;
            grpJSON.TabStop = false;
            grpJSON.Text = "JSON";
            // 
            // txtData
            // 
            txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            txtData.Location = new System.Drawing.Point(3, 19);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.Size = new System.Drawing.Size(772, 467);
            txtData.TabIndex = 0;
            // 
            // InputJsonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 573);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grpJSON);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "InputJsonForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Input JSON";
            grpJSON.ResumeLayout(false);
            grpJSON.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnOK;
        private System.Windows.Forms.GroupBox grpJSON;
        private Krypton.Toolkit.KryptonTextBox txtData;
    }
}