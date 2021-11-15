using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
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
            this.txtTemplate = new Krypton.Toolkit.KryptonTextBox();
            this.grpTemplate = new System.Windows.Forms.GroupBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new Krypton.Toolkit.KryptonTextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new Krypton.Toolkit.KryptonTextBox();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.btnCopy = new Krypton.Toolkit.KryptonButton();
            this.grpTemplate.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTemplate
            // 
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Location = new System.Drawing.Point(3, 16);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(281, 459);
            this.txtTemplate.TabIndex = 0;
            // 
            // grpTemplate
            // 
            this.grpTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTemplate.Controls.Add(this.txtTemplate);
            this.grpTemplate.Location = new System.Drawing.Point(8, 8);
            this.grpTemplate.Name = "grpTemplate";
            this.grpTemplate.Size = new System.Drawing.Size(287, 478);
            this.grpTemplate.TabIndex = 1;
            this.grpTemplate.TabStop = false;
            this.grpTemplate.Text = "Template";
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(301, 8);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(302, 208);
            this.grpInput.TabIndex = 2;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 16);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(296, 189);
            this.txtInput.TabIndex = 0;
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(301, 265);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(302, 218);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(296, 199);
            this.txtOutput.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(301, 222);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 37);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Values.Text = "Create!";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(477, 222);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(126, 37);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Values.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpTemplate);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(614, 497);
            this.grpTemplate.ResumeLayout(false);
            this.grpTemplate.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonTextBox txtTemplate;
        private System.Windows.Forms.GroupBox grpTemplate;
        private System.Windows.Forms.GroupBox grpInput;
        private KryptonTextBox txtInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private KryptonTextBox txtOutput;
        private KryptonButton btnCreate;
        private KryptonButton btnCopy;
    }
}
