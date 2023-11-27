using NEXUS.Forms.Customers;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Customer
    {

        // Ligação à base de dados
        private OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        // Método para inserir um cliente ticket na base de dados
        public void InsertNewCustomer(string CustomerName, string PhoneNumber, string Email, string TaxpayerNumber, string Address)
        {
            // Comando para inserir o cliente 
            OdbcCommand command = new OdbcCommand($"INSERT INTO customers (customer_name, phone_number, email, taxpayer_number, address) VALUES ('{CustomerName}', '{PhoneNumber}', '{Email}', '{TaxpayerNumber}', '{Address}')", connection);

            // Validação dos dados do cliente
            if (CustomerName == string.Empty)
            {
                MessageBox.Show("Erro: É necessário preencher o nome do cliente.");
                return;
            }
            else if (PhoneNumber == string.Empty || Email == string.Empty)
            {
                MessageBox.Show("Erro: É necessário que haja uma forma de contacto Telemóvel ou Email.");
                return;
            }


            // Execução do comando
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

        // Método para carregar todos os clientes para uma DataTable
        public DataTable CustomersDataTable()
        {
            DataTable dataTable = new DataTable();

            // Comando para selecionar um cliente pelo Id
            string command = "SELECT customer_id AS 'Número de cliente', customer_name AS Nome, phone_number AS 'Número telemóvel', email AS Email FROM customers ORDER BY customer_name";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connection);


            // Execução do comando
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

        // Método para abrir a ficha de um determinado cliente
        public void ViewCustomerFile(string CustomerId)
        {
            string command = $"SELECT * FROM customers WHERE customer_id = '{CustomerId}'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connection);
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

        // Método para pesquisar clientes
        public DataTable SearchCustomer(string SearchValue)
        {
            DataTable dataTable = new DataTable();

            // Comando para selecionar o cliente
            string command = $"SELECT customer_id as 'Número de cliente', customer_name AS Nome, phone_number AS 'Número telemóvel', email AS 'Email' FROM customers WHERE customer_name LIKE '{SearchValue}%' ORDER BY customer_name";

            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connection);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
