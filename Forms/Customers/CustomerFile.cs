using System;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NEXUS.Forms.Customers
{
    public partial class CustomerFile : Form
    {
        Customer _Customer = new Customer();

        private string CustomerId;
        private bool editing = false;

        public CustomerFile(string customerId, string name, string phoneNumber, string email, string taxPayerNmber, string address)
        {
            InitializeComponent();

            labelCustomerId.Text = customerId;
            CustomerId = customerId;

            textBoxName.Text = name;
            textBoxPhoneNumber.Text = phoneNumber;
            textBoxEmail.Text = email;
            textBoxTaxPayerNumber.Text = taxPayerNmber;
            textBoxAddress.Text = address;
        }

        private void EditCustomerData()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "customerData")
                    control.Enabled = true;
            }

            editing = true;
            buttonCancelClose.Text = "Cancelar";
            buttonEditCustomerData.Enabled = false;
            buttonSave.Enabled = true;
            buttonDeleteCustomer.Enabled = true;
        }

        private void CancelClose()
        {
            int customerId = Int32.Parse(labelCustomerId.Text);
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string taxpayerNumber = textBoxTaxPayerNumber.Text;
            string address = textBoxAddress.Text;
            string query = $"UPDATE customers SET customer_name = '{name}',phone_number = '{phoneNumber}',[email] = '{email}', taxpayer_number = '{taxpayerNumber}',address = '{address}' WHERE customer_id = '{customerId}'";

            //SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");

            //SqlCommand sqlCommand = new SqlCommand(query, connection);
            OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection);

            odbcConnection.Open();
            odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();

            if (editing)
            {
                buttonCancelClose.Text = "Fechar";
                editing = false;
                buttonEditCustomerData.Enabled = true;
                buttonSave.Enabled = false;

                foreach (Control control in this.Controls)
                {
                    if (control.Tag == "customerData")
                        control.Enabled = false;
                }
            }
            else if (!editing)
            {

                this.Close();
            }
        }

        private void SaveChanges()
        {
            editing = false;
            buttonSave.Enabled = false;
            buttonCancelClose.Text = "Fechar";
            buttonEditCustomerData.Enabled = true;

            foreach (Control control in this.Controls)
            {
                if (control.Tag == "customerData")
                    control.Enabled = false;
            }
        }

        private void buttonEditCustomerData_Click(object sender, EventArgs e)
        {
            EditCustomerData();
        }

        private void buttonCancelClose_Click(object sender, EventArgs e)
        {
            CancelClose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            _Customer.DeleteCustomer(CustomerId);
            this.Close();
        }
    }
}
