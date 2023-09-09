using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class AssociateCustomer : Form
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        public AssociateCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            string query = "SELECT TOP 50 * FROM customers";

            DataTable dataTable = new DataTable();

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(query, odbcConnection);
            odbcDataAdapter.Fill(dataTable);

            dataGridViewCustomers.DataSource = dataTable;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            this.CustomerID = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            this.CustomerName = dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
