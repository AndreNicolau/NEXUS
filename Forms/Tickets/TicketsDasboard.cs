﻿using System;
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
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

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
            string query = $"SELECT ticket_number AS 'Número ticket', open_date AS 'Data abertura', associated_customer AS 'Número cliente', equipment_brand AS 'Marca', equipment_model AS 'Modelo', equipment_type as 'Tipo equipamento', serial_number as 'Número série' FROM tickets  WHERE ticket_number = '{TicketNumber}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, odbcConnection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string openDate = dataTable.Rows[0][1].ToString();
            string customerId = dataTable.Rows[0][2].ToString();
            string brand = dataTable.Rows[0][3].ToString();
            string equipmentType = dataTable.Rows[0][4].ToString();
            string model = dataTable.Rows[0][5].ToString();
            string serialNumber = dataTable.Rows[0][6].ToString();

            TicketOverview ticketOverview = new TicketOverview(TicketNumber, customerId, openDate, brand, model, equipmentType, serialNumber);
            ticketOverview.TopLevel = true;
            ticketOverview.Show();
        }

        private void dataGridViewTickets_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //OverviewTicket();
            TicketNumber = dataGridViewTickets.CurrentRow.Cells[0].Value.ToString();

            DataTable dataTable = new DataTable();
            OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT ticket_number, associated_customer, open_date, equipment_brand, equipment_model, equipment_type, serial_number FROM tickets WHERE ticket_number = '{TicketNumber}'", connection);
            adapter.Fill(dataTable);

            
            string customerId = dataTable.Rows[0][1].ToString();
            string openDate = dataTable.Rows[0][2].ToString();
            string brand = dataTable.Rows[0][3].ToString();
            string model = dataTable.Rows[0][4].ToString();
            string equipmentType = dataTable.Rows[0][5].ToString();
            string serialNumber = dataTable.Rows[0][6].ToString();

            TicketOverview ticket = new TicketOverview(TicketNumber, customerId, openDate, brand, model, equipmentType, serialNumber);
            ticket.Show();
        }

        private void buttonClosedTickets_Click(object sender, EventArgs e)
        {
            dataGridViewTickets.DataSource = _Ticket.LoadClosedTickets();
        }

        private void buttonOpenedTickets_Click(object sender, EventArgs e)
        {
            dataGridViewTickets.DataSource = _Ticket.LoadOpenTickets();
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTickets.DataSource = _Ticket.SearchTickets(textBoxSearchValue.Text);
        }
    }
}
