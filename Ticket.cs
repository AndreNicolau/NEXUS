using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Ticket
    {
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        public void InsertTicket(string AssociatedCustomer, string EquipmentBrand, string EquipmentType, string EquipmentModel, string Description)
        {
            string date = DateTime.Today.ToString("yyyy/MM/dd");
            OdbcCommand command = new OdbcCommand($"INSERT INTO tickets (open_date, associated_customer, equipment_brand, equipment_type, equipment_model, description) VALUES ('{date}', '{AssociatedCustomer}', '{EquipmentBrand}', '{EquipmentType}', '{EquipmentModel}', '{Description}') ", connection);

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
            string query = "SELECT * FROM tickets WHERE state = 'Fechado'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable LoadTicketActions(string TicketNumber)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT description AS 'Descrição', date AS 'Data' FROM ticket_actions WHERE associated_ticket_number = '{TicketNumber}'";
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
