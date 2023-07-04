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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.CornerRoundingRadius = -1F;
            this.btnRun.Location = new System.Drawing.Point(20, 315);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(193, 53);
            this.btnRun.TabIndex = 16;
            this.btnRun.Values.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.CornerRoundingRadius = -1F;
            this.btnBrowseOutput.Location = new System.Drawing.Point(92, 51);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseOutput.TabIndex = 15;
            this.btnBrowseOutput.Values.Text = "Browse";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(92, 22);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(535, 23);
            this.txtOutput.TabIndex = 14;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(14, 25);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 20);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Values.Text = "Output:";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.CornerRoundingRadius = -1F;
            this.btnBrowseInput.Location = new System.Drawing.Point(92, 61);
            this.btnBrowseInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseInput.TabIndex = 12;
            this.btnBrowseInput.Values.Text = "Browse";
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(92, 32);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(535, 23);
            this.txtInput.TabIndex = 11;
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(24, 32);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(42, 20);
            this.lblInput.TabIndex = 10;
            this.lblInput.Values.Text = "Input:";
            // 
            // rbOutputDistinct
            // 
            this.rbOutputDistinct.Location = new System.Drawing.Point(92, 97);
            this.rbOutputDistinct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOutputDistinct.Name = "rbOutputDistinct";
            this.rbOutputDistinct.Size = new System.Drawing.Size(137, 20);
            this.rbOutputDistinct.TabIndex = 17;
            this.rbOutputDistinct.Values.Text = "Output Distinct Lines";
            // 
            // rbOutputMatching
            // 
            this.rbOutputMatching.Location = new System.Drawing.Point(92, 128);
            this.rbOutputMatching.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOutputMatching.Name = "rbOutputMatching";
            this.rbOutputMatching.Size = new System.Drawing.Size(119, 20);
            this.rbOutputMatching.TabIndex = 18;
            this.rbOutputMatching.Values.Text = "Output Matching:";
            // 
            // txtMatching
            // 
            this.txtMatching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatching.Location = new System.Drawing.Point(238, 128);
            this.txtMatching.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatching.Name = "txtMatching";
            this.txtMatching.Size = new System.Drawing.Size(389, 23);
            this.txtMatching.TabIndex = 19;
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Controls.Add(this.lblInput);
            this.grpInput.Controls.Add(this.btnBrowseInput);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(642, 113);
            this.grpInput.TabIndex = 20;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Controls.Add(this.txtMatching);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Controls.Add(this.rbOutputDistinct);
            this.grpOutput.Controls.Add(this.rbOutputMatching);
            this.grpOutput.Location = new System.Drawing.Point(20, 139);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(642, 170);
            this.grpOutput.TabIndex = 21;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(683, 382);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
    }
}
