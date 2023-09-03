using NEXUS.Forms.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM customers", connection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dgvClients.DataSource = dataTable;

            dgvClients.Columns[0].Visible = false;
            dgvClients.Columns[1].HeaderText = "Nome";
            dgvClients.Columns[2].HeaderText = "Número telemóvel";
            dgvClients.Columns[3].HeaderText = "Email";
            dgvClients.Columns[4].HeaderText = "Número contribuinte";
            dgvClients.Columns[5].HeaderText = "Morada";
        }

        private void OpenCustomerFile()
        {
            string name = dgvClients.CurrentRow.Cells[1].Value.ToString();
            string phoneNumber = dgvClients.CurrentRow.Cells[2].Value.ToString();
            string email = dgvClients.CurrentRow.Cells[3].Value.ToString();
            string taxPayerNumber = dgvClients.CurrentRow.Cells[4].Value.ToString();
            string address = dgvClients.CurrentRow.Cells[5].Value.ToString();

            CustomerFile customerFile = new CustomerFile(name, phoneNumber, email, taxPayerNumber, address);
            customerFile.Show();
        }

        private void NewCustomer()
        {
            InsertCustomer insertCustomer = new InsertCustomer();
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
    }
}
