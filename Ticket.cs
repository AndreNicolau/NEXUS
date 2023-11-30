using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Ticket
    {
        // Ligação à base de dados
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        // Método para inserir um novo ticket na base de dados
        public void InsertTicket(string AssociatedCustomer, string EquipmentBrand, string EquipmentType, string EquipmentModel, string Description, string SerialNumber)
        {
            string date = DateTime.Today.ToString("yyyy/MM/dd");
            // Comando para inserir o ticket
            OdbcCommand command = new OdbcCommand($"INSERT INTO tickets (open_date, associated_customer, equipment_brand, equipment_type, equipment_model, description, serial_number) VALUES ('{date}', '{AssociatedCustomer}', '{EquipmentBrand}', '{EquipmentType}', '{EquipmentModel}', '{Description}', '{SerialNumber}') ", connection);

            // Execução do comando
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ticket inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Método para carregar todos os tickets abertos para uma DataGridView
        public DataTable LoadOpenTickets()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ticket_number AS 'Número ticket', state AS 'Estado', open_date AS 'Data abertura', description AS 'Descrição' FROM tickets WHERE state = 'Aberto' ORDER BY open_date";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        // Método para carregar todos os tickets fechados para uma DataGridView
        public DataTable LoadClosedTickets()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ticket_number AS 'Número ticket', state AS 'Estado', close_date AS 'Data fecho', description AS 'Descrição' FROM tickets WHERE state = 'Fechado' ORDER BY close_date";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        // Método para carregar todos as ações de um ticket específico
        public DataTable LoadTicketActions(string TicketNumber)
        {
            DataTable dataTable = new DataTable();
            // Comando para selecionar a descrição e as ações do ticket
            string command = $"SELECT description AS 'Descrição', open_date AS 'Data' FROM tickets WHERE ticket_number = '{TicketNumber}' UNION SELECT description AS 'Descrição', date AS 'Data' FROM ticket_actions WHERE associated_ticket_number = '{TicketNumber}'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connection);

            // Preenchimento da DataTable
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        // Método para inserir uma ação num ticket específico
        public void InsertAction(string TicketNumber, string Description)
        {
            // Comando para inserir a ação no ticket
            OdbcCommand command = new OdbcCommand($"INSERT INTO ticket_actions (associated_ticket_number, description, date) VALUES ('{TicketNumber}', '{Description}', '{DateTime.Today.ToString("yyyy/MM/dd")}')", connection);

            // Execução do comando
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Método para fechar um ticket específico
        public void CloseTicket(string TicketNumber)
        {
            string closeDate = DateTime.Today.ToString("yyyy/MM/dd");
            // Comando para fechar o ticket
            OdbcCommand command = new OdbcCommand($"UPDATE tickets SET state = 'Fechado', close_date = '{closeDate}' WHERE ticket_number = '{TicketNumber}'", connection);

            // Execução do comando
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ticket fechado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método para verificar se o ticket está aberto
        public bool IsTicketOpen(string TicketNumber)
        {
            // Adaptador para preencer a DataTable
            OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT state FROM tickets WHERE ticket_number = '{TicketNumber}'", connection);
            DataTable dataTable = new DataTable();

            // Preenchimento da DataTable
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao verificar se o ticket está aberto! Erro: {ex.Message}");
            }

            if (dataTable.Rows[0][0].ToString() == "Aberto")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void LoadAllTickets()
        {

        }
    }
}
