using ComponentFactory.Krypton.Toolkit;

namespace BBQ.Toolkit.Common.Forms
{
    partial class SqlConnectionControl
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
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTable = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbTable = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbIntegratedSecurity = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblDatabase = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbServer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbDatabase = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblServer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(500, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTable
            // 
            this.lblTable.Location = new System.Drawing.Point(3, 150);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(43, 20);
            this.lblTable.TabIndex = 32;
            this.lblTable.Values.Text = "Table:";
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownWidth = 280;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(72, 147);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(280, 21);
            this.cmbTable.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(72, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 23);
            this.txtPassword.TabIndex = 30;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(3, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Values.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(72, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 23);
            this.txtUserName.TabIndex = 28;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(3, 65);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 20);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Values.Text = "User Name:";
            // 
            // cbIntegratedSecurity
            // 
            this.cbIntegratedSecurity.Checked = true;
            this.cbIntegratedSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIntegratedSecurity.Location = new System.Drawing.Point(72, 36);
            this.cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            this.cbIntegratedSecurity.Size = new System.Drawing.Size(127, 20);
            this.cbIntegratedSecurity.TabIndex = 26;
            this.cbIntegratedSecurity.Values.Text = "Integrated Security";
            this.cbIntegratedSecurity.CheckedChanged += new System.EventHandler(this.cbIntegratedSecurity_CheckedChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(3, 123);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(64, 20);
            this.lblDatabase.TabIndex = 25;
            this.lblDatabase.Values.Text = "Database:";
            // 
            // cmbServer
            // 
            this.cmbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbServer.DropDownWidth = 422;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(72, 9);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(422, 21);
            this.cmbServer.TabIndex = 22;
            this.cmbServer.DropDown += new System.EventHandler(this.cmbServer_DropDown);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownWidth = 280;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(72, 120);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(280, 21);
            this.cmbDatabase.TabIndex = 23;
            this.cmbDatabase.DropDown += new System.EventHandler(this.cmbDatabase_DropDown);
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(3, 12);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 20);
            this.lblServer.TabIndex = 24;
            this.lblServer.Values.Text = "Server:";
            // 
            // SqlConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cbIntegratedSecurity);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.lblServer);
            this.Name = "SqlConnectionControl";
            this.Size = new System.Drawing.Size(578, 187);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonButton btnRefresh;
        private KryptonLabel lblTable;
        private KryptonComboBox cmbTable;
        private KryptonTextBox txtPassword;
        private KryptonLabel lblPassword;
        private KryptonTextBox txtUserName;
        private KryptonLabel lblUserName;
        private KryptonCheckBox cbIntegratedSecurity;
        private KryptonLabel lblDatabase;
        private KryptonComboBox cmbServer;
        private KryptonComboBox cmbDatabase;
        private KryptonLabel lblServer;
    }
}
