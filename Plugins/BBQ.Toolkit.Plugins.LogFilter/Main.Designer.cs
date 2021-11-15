using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.LogFilter
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
            this.btnRun = new Krypton.Toolkit.KryptonButton();
            this.btnBrowseOutput = new Krypton.Toolkit.KryptonButton();
            this.txtOutput = new Krypton.Toolkit.KryptonTextBox();
            this.lblOutput = new Krypton.Toolkit.KryptonLabel();
            this.btnBrowseInput = new Krypton.Toolkit.KryptonButton();
            this.txtInput = new Krypton.Toolkit.KryptonTextBox();
            this.lblInput = new Krypton.Toolkit.KryptonLabel();
            this.rbOutputDistinct = new Krypton.Toolkit.KryptonRadioButton();
            this.rbOutputMatching = new Krypton.Toolkit.KryptonRadioButton();
            this.txtMatching = new Krypton.Toolkit.KryptonTextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(340, 125);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(121, 35);
            this.btnRun.TabIndex = 16;
            this.btnRun.Values.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(467, 93);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 28);
            this.btnBrowseOutput.TabIndex = 15;
            this.btnBrowseOutput.Values.Text = "Browse";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(66, 96);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(395, 23);
            this.txtOutput.TabIndex = 14;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(8, 96);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 20);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Values.Text = "Output:";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(467, 6);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 28);
            this.btnBrowseInput.TabIndex = 12;
            this.btnBrowseInput.Values.Text = "Browse";
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(66, 8);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(395, 23);
            this.txtInput.TabIndex = 11;
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(8, 11);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(42, 20);
            this.lblInput.TabIndex = 10;
            this.lblInput.Values.Text = "Input:";
            // 
            // rbOutputDistinct
            // 
            this.rbOutputDistinct.Location = new System.Drawing.Point(66, 37);
            this.rbOutputDistinct.Name = "rbOutputDistinct";
            this.rbOutputDistinct.Size = new System.Drawing.Size(137, 20);
            this.rbOutputDistinct.TabIndex = 17;
            this.rbOutputDistinct.Values.Text = "Output Distinct Lines";
            // 
            // rbOutputMatching
            // 
            this.rbOutputMatching.Location = new System.Drawing.Point(66, 64);
            this.rbOutputMatching.Name = "rbOutputMatching";
            this.rbOutputMatching.Size = new System.Drawing.Size(119, 20);
            this.rbOutputMatching.TabIndex = 18;
            this.rbOutputMatching.Values.Text = "Output Matching:";
            // 
            // txtMatching
            // 
            this.txtMatching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatching.Location = new System.Drawing.Point(191, 64);
            this.txtMatching.Name = "txtMatching";
            this.txtMatching.Size = new System.Drawing.Size(270, 23);
            this.txtMatching.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtMatching);
            this.Controls.Add(this.rbOutputMatching);
            this.Controls.Add(this.rbOutputDistinct);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(550, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonButton btnRun;
        private KryptonButton btnBrowseOutput;
        private KryptonTextBox txtOutput;
        private KryptonLabel lblOutput;
        private KryptonButton btnBrowseInput;
        private KryptonTextBox txtInput;
        private KryptonLabel lblInput;
        private KryptonRadioButton rbOutputDistinct;
        private KryptonRadioButton rbOutputMatching;
        private KryptonTextBox txtMatching;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}
