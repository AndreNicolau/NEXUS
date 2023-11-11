using NEXUS.Forms.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Customer
    {
        private OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        public void InsertNewCustomer(string CustomerName, string PhoneNumber, string Email, string TaxpayerNumber, string Address) 
        {
            OdbcCommand command = new OdbcCommand($"INSERT INTO customers (customer_name, phone_number, email, taxpayer_number, address) VALUES ('{CustomerName}', '{PhoneNumber}', '{Email}', '{TaxpayerNumber}', '{Address}')", connection);

            if (CustomerName == string.Empty)
            {
                MessageBox.Show("Erro: É necessário preencher o nome do cliente.");
                return;
            } else if (PhoneNumber == string.Empty || Email == string.Empty) 
            {
                MessageBox.Show("Erro: É necessário que haja uma forma de contacto Telemóvel ou Email.");
                return;
            }

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cliente inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public DataTable CustomersDataTable()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT customer_id AS 'Número de cliente', customer_name AS Nome, phone_number AS 'Número telemóvel', email AS Email FROM customers ORDER BY customer_name";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            try
            {
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void ViewCustomerFile(string CustomerId)
        {
            string query = $"SELECT * FROM customers WHERE customer_id = '{CustomerId}'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            string name = dataTable.Rows[0][1].ToString();
            string phoneNumber = dataTable.Rows[0][2].ToString();
            string email = dataTable.Rows[0][3].ToString();
            string taxpayerNumber = dataTable.Rows[0][4].ToString();
            string address = dataTable.Rows[0][5].ToString();

            CustomerFile customerFile = new CustomerFile(CustomerId, name, phoneNumber, email, taxpayerNumber, address);
            customerFile.Show();
        }

        public DataTable SearchCustomer(string SearchValue)
        {
            DataTable dataTable = new DataTable();

            string query = $"SELECT customer_id as 'Número de cliente', customer_name AS Nome, phone_number AS 'Número telemóvel', email AS 'Email' FROM customers WHERE customer_name LIKE '{SearchValue}%' ORDER BY customer_name";

            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
