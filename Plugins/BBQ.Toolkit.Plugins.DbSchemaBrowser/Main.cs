﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Forms;
using Microsoft.Data.SqlClient;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser
{
    public partial class Main : UserControl
    {
        private string ConnectionString
        {
            get { return txtConnectionString.Text; }
            set { txtConnectionString.Text = value; }
        }

        private string Table
        {
            get
            {
                if (cmbTable.SelectedIndex != -1)
                {
                    return cmbTable.SelectedItem.ToString();
                }
                return string.Empty;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnConnectionStringBuilder_Click(object sender, EventArgs e)
        {
            using var form = new SqlConnectionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ConnectionString = form.ConnectionString;
            }
        }

        private void bnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                MessageBox.Show("Connection string has not been set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var schema = connection.GetSchema();
            connection.Close();
            dataGridView.DataSource = schema;

            var metaTables = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                metaTables.Add(row.Field<string>("CollectionName"));
            }
            cmbTable.Items.Clear();
            metaTables.ForEach(x => cmbTable.Items.Add(x));
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var schema = connection.GetSchema(Table);
            connection.Close();
            dataGridView.DataSource = schema;
        }
    }
}