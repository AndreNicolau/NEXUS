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

namespace NEXUS.Forms.Customers
{
    public partial class InsertCustomer : Form
    {
        public InsertCustomer()
        {
            InitializeComponent();
        }

        private void InsertNewCustomer()
        {
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string taxpayerNumber = textBoxTaxPayerNumber.Text;
            string address = textBoxAddress.Text;

            string query = $"INSERT INTO customers (customer_name, phone_number, email, taxpayer_number, address) VALUES ('{name}', '{phoneNumber}', '{email}', '{taxpayerNumber}', '{address}') ";

            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível registar o cliente na base de dados! Erro: {ex}", "Cliente não registado!", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Cliente registado com sucesso", "Cliente registado", MessageBoxButtons.OK);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            InsertNewCustomer();
        }
    }
}
