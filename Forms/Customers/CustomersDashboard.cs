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

            dgvClients.Sort(dgvClients.Columns[1], ListSortDirection.Ascending);

            DataGridViewCellStyle style = dgvClients.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dgvClients.Font, FontStyle.Bold);
        }

        private void OpenCustomerFile()
        {
            string customerId = dgvClients.CurrentRow.Cells[0].Value.ToString();
            
            Customer customer = new Customer();
            customer.ViewCustomerFile(customerId);
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
