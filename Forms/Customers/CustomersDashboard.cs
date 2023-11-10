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
            Customer customer = new Customer();
            dgvClients.DataSource = customer.CustomersDataTable();

            dgvClients.Sort(dgvClients.Columns[0], ListSortDirection.Ascending);

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
