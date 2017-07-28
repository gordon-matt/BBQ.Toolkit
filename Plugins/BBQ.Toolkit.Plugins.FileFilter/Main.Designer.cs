using ComponentFactory.Krypton.Toolkit;

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
            this.lblFile1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFile1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBrowseFile1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBrowseFile2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtFile2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblFile2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnBrowseOutput = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtOutput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnRun = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rbFile1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbFile2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblOutputDifferencesFor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblFile1
            // 
            this.lblFile1.Location = new System.Drawing.Point(11, 15);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(42, 20);
            this.lblFile1.TabIndex = 0;
            this.lblFile1.Values.Text = "File 1:";
            // 
            // txtFile1
            // 
            this.txtFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile1.Location = new System.Drawing.Point(66, 12);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(438, 23);
            this.txtFile1.TabIndex = 1;
            // 
            // btnBrowseFile1
            // 
            this.btnBrowseFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile1.Location = new System.Drawing.Point(510, 10);
            this.btnBrowseFile1.Name = "btnBrowseFile1";
            this.btnBrowseFile1.Size = new System.Drawing.Size(75, 28);
            this.btnBrowseFile1.TabIndex = 2;
            this.btnBrowseFile1.Values.Text = "Browse";
            this.btnBrowseFile1.Click += new System.EventHandler(this.btnBrowseFile1_Click);
            // 
            // btnBrowseFile2
            // 
            this.btnBrowseFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile2.Location = new System.Drawing.Point(510, 44);
            this.btnBrowseFile2.Name = "btnBrowseFile2";
            this.btnBrowseFile2.Size = new System.Drawing.Size(75, 28);
            this.btnBrowseFile2.TabIndex = 5;
            this.btnBrowseFile2.Values.Text = "Browse";
            this.btnBrowseFile2.Click += new System.EventHandler(this.btnBrowseFile2_Click);
            // 
            // txtFile2
            // 
            this.txtFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile2.Location = new System.Drawing.Point(66, 46);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(438, 23);
            this.txtFile2.TabIndex = 4;
            // 
            // lblFile2
            // 
            this.lblFile2.Location = new System.Drawing.Point(11, 49);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(42, 20);
            this.lblFile2.TabIndex = 3;
            this.lblFile2.Values.Text = "File 2:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(510, 99);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 28);
            this.btnBrowseOutput.TabIndex = 8;
            this.btnBrowseOutput.Values.Text = "Browse";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(66, 101);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(438, 23);
            this.txtOutput.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(8, 103);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Values.Text = "Output:";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(383, 130);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(121, 35);
            this.btnRun.TabIndex = 9;
            this.btnRun.Values.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbFile1
            // 
            this.rbFile1.Checked = true;
            this.rbFile1.Location = new System.Drawing.Point(210, 75);
            this.rbFile1.Name = "rbFile1";
            this.rbFile1.Size = new System.Drawing.Size(51, 20);
            this.rbFile1.TabIndex = 10;
            this.rbFile1.Values.Text = "File 1";
            // 
            // rbFile2
            // 
            this.rbFile2.Location = new System.Drawing.Point(267, 75);
            this.rbFile2.Name = "rbFile2";
            this.rbFile2.Size = new System.Drawing.Size(51, 20);
            this.rbFile2.TabIndex = 11;
            this.rbFile2.Values.Text = "File 2";
            // 
            // lblOutputDifferencesFor
            // 
            this.lblOutputDifferencesFor.Location = new System.Drawing.Point(66, 75);
            this.lblOutputDifferencesFor.Name = "lblOutputDifferencesFor";
            this.lblOutputDifferencesFor.Size = new System.Drawing.Size(138, 20);
            this.lblOutputDifferencesFor.TabIndex = 12;
            this.lblOutputDifferencesFor.Values.Text = "Output Differences For:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblOutputDifferencesFor);
            this.Controls.Add(this.rbFile2);
            this.Controls.Add(this.rbFile1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBrowseFile2);
            this.Controls.Add(this.txtFile2);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.btnBrowseFile1);
            this.Controls.Add(this.txtFile1);
            this.Controls.Add(this.lblFile1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(597, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
