using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Ticket
    {
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        public void InsertTicket(string AssociatedCustomer, string EquipmentBrand, string EquipmentType, string EquipmentModel, string Description, string SerialNumber)
        {
            string date = DateTime.Today.ToString("yyyy/MM/dd");
            OdbcCommand command = new OdbcCommand($"INSERT INTO tickets (open_date, associated_customer, equipment_brand, equipment_type, equipment_model, description, serial_number) VALUES ('{date}', '{AssociatedCustomer}', '{EquipmentBrand}', '{EquipmentType}', '{EquipmentModel}', '{Description}', '{SerialNumber}') ", connection);

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

        public DataTable LoadOpenTickets()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ticket_number AS 'Número ticket', state AS 'Estado', open_date AS 'Data abertura', description AS 'Descrição' FROM tickets WHERE state = 'Aberto' ORDER BY open_date";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable LoadClosedTickets()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ticket_number AS 'Número ticket', state AS 'Estado', close_date AS 'Data fecho', description AS 'Descrição' FROM tickets WHERE state = 'Fechado' ORDER BY close_date";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable LoadTicketActions(string TicketNumber)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT description AS 'Descrição', open_date AS 'Data' FROM tickets WHERE ticket_number = '{TicketNumber}' UNION SELECT description AS 'Descrição', date AS 'Data' FROM ticket_actions WHERE associated_ticket_number = '{TicketNumber}'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public void InsertAction(string TicketNumber, string Description)
        {
            OdbcCommand command = new OdbcCommand($"INSERT INTO ticket_actions (associated_ticket_number, description, date) VALUES ('{TicketNumber}', '{Description}', '{DateTime.Today.ToString("yyyy/MM/dd")}')", connection);

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

        public void CloseTicket(string TicketNumber)
        {
            string closeDate = DateTime.Today.ToString("yyyy/MM/dd");
            OdbcCommand command = new OdbcCommand($"UPDATE tickets SET state = 'Fechado', close_date = '{closeDate}' WHERE ticket_number = '{TicketNumber}'", connection);

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
    }
}
