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
        Customer _Customer = new Customer();

        public CustomersDashboard()
        {
            InitializeComponent();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvClients.DataSource = _Customer.CustomersDataTable();

            DataGridViewCellStyle style = dgvClients.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dgvClients.Font, FontStyle.Bold);
        }

        private void OpenCustomerFile()
        {
            string customerId = dgvClients.CurrentRow.Cells[0].Value.ToString();
            
            _Customer.ViewCustomerFile(customerId);
        }

        private void NewCustomer()
        {
            RegisterNewCustomer insertCustomer = new RegisterNewCustomer();
            insertCustomer.Show();
        }

        private void SearchCustomer()
        {
            string searchValue = textBoxSearchValue.Text;
            dgvClients.DataSource = _Customer.SearchCustomer(searchValue);
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

        private void dgvClients_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenCustomerFile();
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }
    }
}
