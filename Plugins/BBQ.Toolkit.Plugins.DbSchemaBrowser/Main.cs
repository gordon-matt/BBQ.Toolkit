using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Forms;
using Microsoft.Data.SqlClient;

namespace BBQ.Toolkit.Plugins.DbSchemaBrowser
{
    public partial class Main : UserControl
    {
        private string connectionString;

        private string Table
        {
            get
            {
                if (lbTables.SelectedIndex != -1)
                {
                    return lbTables.SelectedItem.ToString();
                }
                return string.Empty;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var schema = connection.GetSchema(Table);
            connection.Close();
            dataGridView.DataSource = schema;
        }

        private void btnWizard_Click(object sender, EventArgs e)
        {
            using var form = new SqlConnectionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                connectionString = form.ConnectionString;
                Connect();
            }
        }

        private void btnConnectionString_Click(object sender, EventArgs e)
        {
            using var form = new ConnectionStringDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                connectionString = form.ConnectionString;
                Connect();
            }
        }

        private void Connect()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string has not been set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var schema = connection.GetSchema();
            connection.Close();
            dataGridView.DataSource = schema;

            var metaTables = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                metaTables.Add(row.Field<string>("CollectionName"));
            }
            lbTables.DataSource = metaTables.OrderBy(x => x).ToList();
        }
    }
}