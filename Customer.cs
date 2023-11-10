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

            string query = "SELECT customer_name AS Nome, phone_number AS 'Número telemóvel', email AS Email FROM customers";
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
    }
}
