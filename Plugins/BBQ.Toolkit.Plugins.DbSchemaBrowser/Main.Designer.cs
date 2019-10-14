using ComponentFactory.Krypton.Toolkit;

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
            this.lblConnectionString = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtConnectionString = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bnConnect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTable = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbTable = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnConnectionStringBuilder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Location = new System.Drawing.Point(12, 10);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(111, 20);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Values.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(129, 10);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(339, 23);
            this.txtConnectionString.TabIndex = 1;
            // 
            // bnConnect
            // 
            this.bnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnConnect.Location = new System.Drawing.Point(513, 7);
            this.bnConnect.Name = "bnConnect";
            this.bnConnect.Size = new System.Drawing.Size(62, 28);
            this.bnConnect.TabIndex = 7;
            this.bnConnect.Values.Text = "Connect";
            this.bnConnect.Click += new System.EventHandler(this.bnConnect_Click);
            // 
            // lblTable
            // 
            this.lblTable.Location = new System.Drawing.Point(12, 39);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(43, 20);
            this.lblTable.TabIndex = 6;
            this.lblTable.Values.Text = "Table:";
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownWidth = 218;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(129, 39);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(218, 21);
            this.cmbTable.Sorted = true;
            this.cmbTable.TabIndex = 5;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // btnConnectionStringBuilder
            // 
            this.btnConnectionStringBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionStringBuilder.Location = new System.Drawing.Point(474, 7);
            this.btnConnectionStringBuilder.Name = "btnConnectionStringBuilder";
            this.btnConnectionStringBuilder.Size = new System.Drawing.Size(33, 28);
            this.btnConnectionStringBuilder.TabIndex = 4;
            this.btnConnectionStringBuilder.Values.Text = "...";
            this.btnConnectionStringBuilder.Click += new System.EventHandler(this.btnConnectionStringBuilder_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(589, 340);
            this.dataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnConnect);
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.txtConnectionString);
            this.panel1.Controls.Add(this.cmbTable);
            this.panel1.Controls.Add(this.lblConnectionString);
            this.panel1.Controls.Add(this.btnConnectionStringBuilder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 77);
            this.panel1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(589, 417);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KryptonLabel lblConnectionString;
        private KryptonTextBox txtConnectionString;
        private KryptonButton btnConnectionStringBuilder;
        private KryptonLabel lblTable;
        private KryptonComboBox cmbTable;
        private KryptonDataGridView dataGridView;
        private KryptonButton bnConnect;
        private System.Windows.Forms.Panel panel1;
    }
}
