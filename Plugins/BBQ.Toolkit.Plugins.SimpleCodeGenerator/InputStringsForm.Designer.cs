namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
{
    partial class InputStringsForm
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
            grpItems = new System.Windows.Forms.GroupBox();
            grpParse = new System.Windows.Forms.GroupBox();
            txtData = new Krypton.Toolkit.KryptonTextBox();
            btnOK = new Krypton.Toolkit.KryptonButton();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            btnParse = new Krypton.Toolkit.KryptonButton();
            lbItems = new Krypton.Toolkit.KryptonListBox();
            grpItems.SuspendLayout();
            grpParse.SuspendLayout();
            SuspendLayout();
            // 
            // grpItems
            // 
            grpItems.Controls.Add(lbItems);
            grpItems.Location = new System.Drawing.Point(12, 12);
            grpItems.Name = "grpItems";
            grpItems.Size = new System.Drawing.Size(270, 549);
            grpItems.TabIndex = 0;
            grpItems.TabStop = false;
            grpItems.Text = "Items";
            // 
            // grpParse
            // 
            grpParse.Controls.Add(txtData);
            grpParse.Location = new System.Drawing.Point(288, 12);
            grpParse.Name = "grpParse";
            grpParse.Size = new System.Drawing.Size(502, 489);
            grpParse.TabIndex = 1;
            grpParse.TabStop = false;
            grpParse.Text = "Parse";
            // 
            // txtData
            // 
            txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            txtData.Location = new System.Drawing.Point(3, 19);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.Size = new System.Drawing.Size(496, 467);
            txtData.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.CornerRoundingRadius = -1F;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(632, 507);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(158, 54);
            btnOK.TabIndex = 2;
            btnOK.Values.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = -1F;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(462, 507);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 54);
            btnCancel.TabIndex = 3;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnParse
            // 
            btnParse.CornerRoundingRadius = -1F;
            btnParse.Location = new System.Drawing.Point(291, 507);
            btnParse.Name = "btnParse";
            btnParse.Size = new System.Drawing.Size(158, 54);
            btnParse.TabIndex = 4;
            btnParse.Values.Image = Properties.Resources.MoveLeft_32x32;
            btnParse.Values.Text = "Parse";
            btnParse.Click += btnParse_Click;
            // 
            // lbItems
            // 
            lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            lbItems.Location = new System.Drawing.Point(3, 19);
            lbItems.Name = "lbItems";
            lbItems.Size = new System.Drawing.Size(264, 527);
            lbItems.TabIndex = 0;
            // 
            // InputStringsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 573);
            Controls.Add(btnParse);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grpParse);
            Controls.Add(grpItems);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "InputStringsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Input Strings";
            grpItems.ResumeLayout(false);
            grpParse.ResumeLayout(false);
            grpParse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.GroupBox grpParse;
        private Krypton.Toolkit.KryptonTextBox txtData;
        private Krypton.Toolkit.KryptonButton btnOK;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnParse;
        private Krypton.Toolkit.KryptonListBox lbItems;
    }
}