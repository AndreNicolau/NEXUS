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
        public TicketsDasboard()
        {
            InitializeComponent();
            LoadTickets();
        }

        private void LoadTickets()
        {
            string query = "SELECT TOP (100) [ticket_number], [state], [open_date], [close_date], [equipment_type], [description]  FROM [nexus].[dbo].[tickets]";

            DataTable dataTable = new DataTable();

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(query, odbcConnection);
            odbcDataAdapter.Fill(dataTable);

            dataGridViewTickets.DataSource = dataTable;

            dataGridViewTickets.Columns[0].HeaderText = "Número do ticket";
            dataGridViewTickets.Columns[1].HeaderText = "Estado";
            dataGridViewTickets.Columns[2].HeaderText = "Data de abertura";
            dataGridViewTickets.Columns[3].HeaderText = "Data de fecho";
            dataGridViewTickets.Columns[4].HeaderText = "Tipo de equipamento";
            dataGridViewTickets.Columns[5].HeaderText = "Descrição";

            dataGridViewTickets.Sort(dataGridViewTickets.Columns[0], ListSortDirection.Descending);

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

        private void OverviewTicket(object sender, DataGridViewCellEventArgs e)
        {
            string ticketNumber = dataGridViewTickets.CurrentRow.Cells[0].Value.ToString();

            string query = $"SELECT * FROM tickets WHERE ticket_number = '{ticketNumber}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, odbcConnection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string openDate = dataTable.Rows[0][2].ToString();
            string customerId = dataTable.Rows[0][4].ToString();
            string brand = dataTable.Rows[0][5].ToString();
            string equipmentType = dataTable.Rows[0][6].ToString();
            string model = dataTable.Rows[0][7].ToString();

            TicketOverview ticketOverview = new TicketOverview(ticketNumber, customerId, openDate, brand, model, equipmentType);
            ticketOverview.TopLevel = true;
            ticketOverview.Show();
        }
    }
}
