using NEXUS.Forms;
using NEXUS.Forms.Tickets;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        public void OpenCustomersDashboard()
        {
            CustomersDashboard customersDashboard = new CustomersDashboard();
            customersDashboard.TopLevel = false;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(customersDashboard);

            customersDashboard.Dock = DockStyle.Fill;
            customersDashboard.Show();
        }

        public void OpenTicketsDashboard()
        {
            TicketsDasboard ticketsDasboard = new TicketsDasboard();
            ticketsDasboard.TopLevel = false;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ticketsDasboard);

            ticketsDasboard.Dock = DockStyle.Fill;
            ticketsDasboard.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            OpenCustomersDashboard();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            OpenTicketsDashboard();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
