using System;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class TicketsDasboard : Form
    {
        Ticket _Ticket = new Ticket();
        string TicketNumber;

        public TicketsDasboard()
        {
            InitializeComponent();
            LoadTickets();
        }

        private void LoadTickets()
        {
            dataGridViewTickets.DataSource = _Ticket.LoadOpenTickets();

            DataGridViewCellStyle style = dataGridViewTickets.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dataGridViewTickets.Font, FontStyle.Bold);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void buttonNewTicket_Click(object sender, EventArgs e)
        {
            RegisterNewTicket newTicket = new RegisterNewTicket();
            newTicket.Show();
        }

        private void OverviewTicket()
        {
            string query = $"SELECT * FROM tickets WHERE ticket_number = '{TicketNumber}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, odbcConnection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string openDate = dataTable.Rows[0][2].ToString();
            string customerId = dataTable.Rows[0][4].ToString();
            string brand = dataTable.Rows[0][5].ToString();
            string equipmentType = dataTable.Rows[0][6].ToString();
            string model = dataTable.Rows[0][7].ToString();
            string serialNumber = dataTable.Rows[0][9].ToString();

            TicketOverview ticketOverview = new TicketOverview(TicketNumber, customerId, openDate, brand, model, equipmentType, serialNumber);
            ticketOverview.TopLevel = true;
            ticketOverview.Show();
        }

        private void radioButtonClosedTickets_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTickets.DataSource = _Ticket.LoadClosedTickets();
        }

        private void radioButtonOpened_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTickets.DataSource = _Ticket.LoadOpenTickets();
        }

        private void dataGridViewTickets_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OverviewTicket();
        }

        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            TicketNumber = dataGridViewTickets.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
