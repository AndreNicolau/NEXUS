using NEXUS.Forms.Customers;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class CustomersDashboard : Form
    {
        public CustomersDashboard()
        {
            InitializeComponent();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter("SELECT * FROM customers", odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            dgvClients.DataSource = dataTable;

            dgvClients.Columns[0].Visible = false;
            dgvClients.Columns[1].HeaderText = "Nome";
            dgvClients.Columns[2].HeaderText = "Número telemóvel";
            dgvClients.Columns[3].HeaderText = "Email";
            dgvClients.Columns[4].HeaderText = "Número contribuinte";
            dgvClients.Columns[5].HeaderText = "Morada";

            dgvClients.Sort(dgvClients.Columns[1], ListSortDirection.Ascending);

            DataGridViewCellStyle style = dgvClients.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dgvClients.Font, FontStyle.Bold);
        }

        private void OpenCustomerFile()
        {
            string customerId = dgvClients.CurrentRow.Cells[0].Value.ToString();
            string name = dgvClients.CurrentRow.Cells[1].Value.ToString();
            string phoneNumber = dgvClients.CurrentRow.Cells[2].Value.ToString();
            string email = dgvClients.CurrentRow.Cells[3].Value.ToString();
            string taxPayerNumber = dgvClients.CurrentRow.Cells[4].Value.ToString();
            string address = dgvClients.CurrentRow.Cells[5].Value.ToString();

            CustomerFile customerFile = new CustomerFile(customerId, name, phoneNumber, email, taxPayerNumber, address);
            customerFile.Show();
        }

        private void NewCustomer()
        {
            RegisterNewCustomer insertCustomer = new RegisterNewCustomer();
            insertCustomer.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CustomerSearch clientSearch = new CustomerSearch();
            clientSearch.Show();
        }

        private void buttonOpenCustomerFile_Click(object sender, EventArgs e)
        {
            OpenCustomerFile();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            NewCustomer();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
