﻿using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.FileDiffOutput
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
            this.lblFile1 = new Krypton.Toolkit.KryptonLabel();
            this.txtFile1 = new Krypton.Toolkit.KryptonTextBox();
            this.btnBrowseFile1 = new Krypton.Toolkit.KryptonButton();
            this.btnBrowseFile2 = new Krypton.Toolkit.KryptonButton();
            this.txtFile2 = new Krypton.Toolkit.KryptonTextBox();
            this.lblFile2 = new Krypton.Toolkit.KryptonLabel();
            this.btnBrowseOutput = new Krypton.Toolkit.KryptonButton();
            this.txtOutput = new Krypton.Toolkit.KryptonTextBox();
            this.lblOutput = new Krypton.Toolkit.KryptonLabel();
            this.btnRun = new Krypton.Toolkit.KryptonButton();
            this.rbFile1 = new Krypton.Toolkit.KryptonRadioButton();
            this.rbFile2 = new Krypton.Toolkit.KryptonRadioButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblOutputDifferencesFor = new Krypton.Toolkit.KryptonLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile1
            // 
            this.lblFile1.Location = new System.Drawing.Point(14, 35);
            this.lblFile1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(42, 20);
            this.lblFile1.TabIndex = 0;
            this.lblFile1.Values.Text = "File 1:";
            // 
            // txtFile1
            // 
            this.txtFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile1.Location = new System.Drawing.Point(82, 32);
            this.txtFile1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(593, 23);
            this.txtFile1.TabIndex = 1;
            // 
            // btnBrowseFile1
            // 
            this.btnBrowseFile1.CornerRoundingRadius = -1F;
            this.btnBrowseFile1.Location = new System.Drawing.Point(82, 61);
            this.btnBrowseFile1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile1.Name = "btnBrowseFile1";
            this.btnBrowseFile1.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseFile1.TabIndex = 2;
            this.btnBrowseFile1.Values.Text = "Browse";
            this.btnBrowseFile1.Click += new System.EventHandler(this.btnBrowseFile1_Click);
            // 
            // btnBrowseFile2
            // 
            this.btnBrowseFile2.CornerRoundingRadius = -1F;
            this.btnBrowseFile2.Location = new System.Drawing.Point(82, 136);
            this.btnBrowseFile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile2.Name = "btnBrowseFile2";
            this.btnBrowseFile2.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseFile2.TabIndex = 5;
            this.btnBrowseFile2.Values.Text = "Browse";
            this.btnBrowseFile2.Click += new System.EventHandler(this.btnBrowseFile2_Click);
            // 
            // txtFile2
            // 
            this.txtFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile2.Location = new System.Drawing.Point(82, 107);
            this.txtFile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(593, 23);
            this.txtFile2.TabIndex = 4;
            // 
            // lblFile2
            // 
            this.lblFile2.Location = new System.Drawing.Point(14, 111);
            this.lblFile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(42, 20);
            this.lblFile2.TabIndex = 3;
            this.lblFile2.Values.Text = "File 2:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.CornerRoundingRadius = -1F;
            this.btnBrowseOutput.Location = new System.Drawing.Point(82, 77);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(104, 40);
            this.btnBrowseOutput.TabIndex = 8;
            this.btnBrowseOutput.Values.Text = "Browse";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(82, 48);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(585, 23);
            this.txtOutput.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(14, 50);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Values.Text = "Output:";
            // 
            // btnRun
            // 
            this.btnRun.CornerRoundingRadius = -1F;
            this.btnRun.Location = new System.Drawing.Point(20, 358);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(194, 56);
            this.btnRun.TabIndex = 9;
            this.btnRun.Values.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbFile1
            // 
            this.rbFile1.Checked = true;
            this.rbFile1.Location = new System.Drawing.Point(250, 22);
            this.rbFile1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbFile1.Name = "rbFile1";
            this.rbFile1.Size = new System.Drawing.Size(51, 20);
            this.rbFile1.TabIndex = 10;
            this.rbFile1.Values.Text = "File 1";
            // 
            // rbFile2
            // 
            this.rbFile2.Location = new System.Drawing.Point(317, 22);
            this.rbFile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbFile2.Name = "rbFile2";
            this.rbFile2.Size = new System.Drawing.Size(51, 20);
            this.rbFile2.TabIndex = 11;
            this.rbFile2.Values.Text = "File 2";
            // 
            // lblOutputDifferencesFor
            // 
            this.lblOutputDifferencesFor.Location = new System.Drawing.Point(82, 22);
            this.lblOutputDifferencesFor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblOutputDifferencesFor.Name = "lblOutputDifferencesFor";
            this.lblOutputDifferencesFor.Size = new System.Drawing.Size(138, 20);
            this.lblOutputDifferencesFor.TabIndex = 12;
            this.lblOutputDifferencesFor.Values.Text = "Output Differences For:";
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.lblFile1);
            this.grpInput.Controls.Add(this.txtFile1);
            this.grpInput.Controls.Add(this.btnBrowseFile1);
            this.grpInput.Controls.Add(this.lblFile2);
            this.grpInput.Controls.Add(this.txtFile2);
            this.grpInput.Controls.Add(this.btnBrowseFile2);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(690, 193);
            this.grpInput.TabIndex = 13;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.lblOutputDifferencesFor);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Controls.Add(this.rbFile2);
            this.grpOutput.Controls.Add(this.rbFile1);
            this.grpOutput.Location = new System.Drawing.Point(20, 219);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(690, 133);
            this.grpOutput.TabIndex = 14;
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
            this.Size = new System.Drawing.Size(730, 430);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonLabel lblFile1;
        private KryptonTextBox txtFile1;
        private KryptonButton btnBrowseFile1;
        private KryptonButton btnBrowseFile2;
        private KryptonTextBox txtFile2;
        private KryptonLabel lblFile2;
        private KryptonButton btnBrowseOutput;
        private KryptonTextBox txtOutput;
        private KryptonLabel lblOutput;
        private KryptonButton btnRun;
        private KryptonRadioButton rbFile1;
        private KryptonRadioButton rbFile2;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private KryptonLabel lblOutputDifferencesFor;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
    }
}
