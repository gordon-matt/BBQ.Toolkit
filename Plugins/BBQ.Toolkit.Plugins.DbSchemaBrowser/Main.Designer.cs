using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser
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
            dataGridView = new KryptonDataGridView();
            panel1 = new System.Windows.Forms.Panel();
            toolStrip = new KryptonToolStrip();
            btnWizard = new System.Windows.Forms.ToolStripButton();
            btnConnectionString = new System.Windows.Forms.ToolStripButton();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lbTables = new KryptonListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new System.Drawing.Size(454, 441);
            dataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(687, 40);
            panel1.TabIndex = 4;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnWizard, btnConnectionString });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(687, 39);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "kryptonToolStrip1";
            // 
            // btnWizard
            // 
            btnWizard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnWizard.Image = Properties.Resources.Wizard_32x32;
            btnWizard.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnWizard.Name = "btnWizard";
            btnWizard.Size = new System.Drawing.Size(36, 36);
            btnWizard.Text = "Wizard Connect";
            btnWizard.Click += btnWizard_Click;
            // 
            // btnConnectionString
            // 
            btnConnectionString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnConnectionString.Image = Properties.Resources.TextInput_32x32;
            btnConnectionString.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnConnectionString.Name = "btnConnectionString";
            btnConnectionString.Size = new System.Drawing.Size(36, 36);
            btnConnectionString.Text = "Paste Connection String";
            btnConnectionString.Click += btnConnectionString_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbTables);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView);
            splitContainer1.Size = new System.Drawing.Size(687, 441);
            splitContainer1.SplitterDistance = 229;
            splitContainer1.TabIndex = 5;
            // 
            // lbTables
            // 
            lbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            lbTables.Location = new System.Drawing.Point(0, 0);
            lbTables.Name = "lbTables";
            lbTables.Size = new System.Drawing.Size(229, 441);
            lbTables.TabIndex = 0;
            lbTables.SelectedIndexChanged += lbTables_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(687, 481);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private KryptonDataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private KryptonListBox lbTables;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnWizard;
        private System.Windows.Forms.ToolStripButton btnConnectionString;
    }
}
