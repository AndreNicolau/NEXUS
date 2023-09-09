using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

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
            string query = "SELECT TOP 50 * FROM tickets";

            DataTable dataTable = new DataTable();

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(query, odbcConnection);
            odbcDataAdapter.Fill(dataTable);

            dgvtickets.DataSource = dataTable;

            dgvtickets.Columns[0].HeaderText = "Número do ticket";
            dgvtickets.Columns[1].HeaderText = "Estado";
            dgvtickets.Columns[2].HeaderText = "Data de abertura";
            dgvtickets.Columns[3].HeaderText = "Data de fecho";
            dgvtickets.Columns[4].HeaderText = "Cliente associado";

            dgvtickets.Sort(dgvtickets.Columns[0], ListSortDirection.Descending);

            DataGridViewCellStyle style = dgvtickets.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dgvtickets.Font, FontStyle.Bold);
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
    }
}
