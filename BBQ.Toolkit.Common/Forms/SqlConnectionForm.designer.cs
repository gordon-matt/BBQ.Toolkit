namespace BBQ.Toolkit.Common.Forms
{
    partial class SqlConnectionForm 
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
            txtPassword = new KryptonTextBox();
            txtUserName = new KryptonTextBox();
            grpConnectDatabase = new GroupBox();
            lblDatabase = new KryptonLabel();
            cmbDatabase = new KryptonComboBox();
            txtServer = new KryptonTextBox();
            lblServer = new KryptonLabel();
            grpLogOnServer = new GroupBox();
            lblPassword = new KryptonLabel();
            lblUserName = new KryptonLabel();
            rbUseSqlServerAuthentication = new KryptonRadioButton();
            rbUseWindowsAuthentication = new KryptonRadioButton();
            btnOK = new KryptonButton();
            btnCancel = new KryptonButton();
            grpConnectDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDatabase).BeginInit();
            grpLogOnServer.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(115, 113);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(346, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Enabled = false;
            txtUserName.Location = new Point(115, 84);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(346, 23);
            txtUserName.TabIndex = 3;
            // 
            // grpConnectDatabase
            // 
            grpConnectDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConnectDatabase.Controls.Add(lblDatabase);
            grpConnectDatabase.Controls.Add(cmbDatabase);
            grpConnectDatabase.Location = new Point(13, 227);
            grpConnectDatabase.Margin = new Padding(4, 3, 4, 3);
            grpConnectDatabase.Name = "grpConnectDatabase";
            grpConnectDatabase.Padding = new Padding(4, 3, 4, 3);
            grpConnectDatabase.Size = new Size(469, 71);
            grpConnectDatabase.TabIndex = 7;
            grpConnectDatabase.TabStop = false;
            grpConnectDatabase.Text = "Connect to a database";
            // 
            // lblDatabase
            // 
            lblDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatabase.Location = new Point(15, 31);
            lblDatabase.Margin = new Padding(4, 0, 4, 0);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(61, 20);
            lblDatabase.TabIndex = 0;
            lblDatabase.Values.Text = "Database";
            // 
            // cmbDatabase
            // 
            cmbDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDatabase.CornerRoundingRadius = -1F;
            cmbDatabase.DropDownWidth = 334;
            cmbDatabase.FormattingEnabled = true;
            cmbDatabase.IntegralHeight = false;
            cmbDatabase.Location = new Point(83, 28);
            cmbDatabase.Margin = new Padding(4, 3, 4, 3);
            cmbDatabase.Name = "cmbDatabase";
            cmbDatabase.Size = new Size(378, 21);
            cmbDatabase.Sorted = true;
            cmbDatabase.TabIndex = 1;
            cmbDatabase.DropDown += cmbDatabase_DropDown;
            // 
            // txtServer
            // 
            txtServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtServer.Location = new Point(13, 38);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(470, 23);
            txtServer.TabIndex = 5;
            // 
            // lblServer
            // 
            lblServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblServer.Location = new Point(13, 12);
            lblServer.Margin = new Padding(4, 3, 4, 3);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(47, 20);
            lblServer.TabIndex = 4;
            lblServer.Values.Text = "Server:";
            // 
            // grpLogOnServer
            // 
            grpLogOnServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLogOnServer.Controls.Add(lblPassword);
            grpLogOnServer.Controls.Add(lblUserName);
            grpLogOnServer.Controls.Add(rbUseSqlServerAuthentication);
            grpLogOnServer.Controls.Add(txtPassword);
            grpLogOnServer.Controls.Add(rbUseWindowsAuthentication);
            grpLogOnServer.Controls.Add(txtUserName);
            grpLogOnServer.Location = new Point(13, 67);
            grpLogOnServer.Margin = new Padding(4, 3, 4, 3);
            grpLogOnServer.Name = "grpLogOnServer";
            grpLogOnServer.Padding = new Padding(4, 3, 4, 3);
            grpLogOnServer.Size = new Size(469, 153);
            grpLogOnServer.TabIndex = 6;
            grpLogOnServer.TabStop = false;
            grpLogOnServer.Text = "Log on to the server";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.Enabled = false;
            lblPassword.Location = new Point(39, 119);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Values.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUserName.Enabled = false;
            lblUserName.Location = new Point(39, 89);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(71, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Values.Text = "User Name";
            // 
            // rbUseSqlServerAuthentication
            // 
            rbUseSqlServerAuthentication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbUseSqlServerAuthentication.Location = new Point(18, 59);
            rbUseSqlServerAuthentication.Margin = new Padding(4, 3, 4, 3);
            rbUseSqlServerAuthentication.Name = "rbUseSqlServerAuthentication";
            rbUseSqlServerAuthentication.Size = new Size(189, 20);
            rbUseSqlServerAuthentication.TabIndex = 1;
            rbUseSqlServerAuthentication.Values.Text = "Use SQL Server Authentication";
            rbUseSqlServerAuthentication.CheckedChanged += rbIntegratedSecurity_CheckedChanged;
            // 
            // rbUseWindowsAuthentication
            // 
            rbUseWindowsAuthentication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbUseWindowsAuthentication.Checked = true;
            rbUseWindowsAuthentication.Location = new Point(18, 32);
            rbUseWindowsAuthentication.Margin = new Padding(4, 3, 4, 3);
            rbUseWindowsAuthentication.Name = "rbUseWindowsAuthentication";
            rbUseWindowsAuthentication.Size = new Size(180, 20);
            rbUseWindowsAuthentication.TabIndex = 0;
            rbUseWindowsAuthentication.Values.Text = "Use Windows Authentication";
            rbUseWindowsAuthentication.CheckedChanged += rbIntegratedSecurity_CheckedChanged;
            // 
            // btnOK
            // 
            btnOK.CornerRoundingRadius = -1F;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(291, 304);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(88, 39);
            btnOK.TabIndex = 8;
            btnOK.Values.Image = Properties.CommonImages.Connect_32x32;
            btnOK.Values.Text = "OK";
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = -1F;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(387, 304);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 39);
            btnCancel.TabIndex = 9;
            btnCancel.Values.Image = Properties.CommonImages.Cancel_32x32;
            btnCancel.Values.Text = "Cancel";
            // 
            // SqlConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 352);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(grpConnectDatabase);
            Controls.Add(txtServer);
            Controls.Add(lblServer);
            Controls.Add(grpLogOnServer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SqlConnectionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Connection";
            grpConnectDatabase.ResumeLayout(false);
            grpConnectDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDatabase).EndInit();
            grpLogOnServer.ResumeLayout(false);
            grpLogOnServer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonTextBox txtPassword;
        private KryptonTextBox txtUserName;
        private GroupBox grpConnectDatabase;
        private KryptonLabel lblDatabase;
        private KryptonComboBox cmbDatabase;
        private KryptonTextBox txtServer;
        private KryptonLabel lblServer;
        private GroupBox grpLogOnServer;
        private KryptonLabel lblPassword;
        private KryptonLabel lblUserName;
        private KryptonRadioButton rbUseSqlServerAuthentication;
        private KryptonRadioButton rbUseWindowsAuthentication;
        private KryptonButton btnOK;
        private KryptonButton btnCancel;
    }
}