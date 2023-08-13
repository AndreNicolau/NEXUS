using System;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();

            dialogResult = MessageBox.Show("De certeza que deseja mesmo encerrar a aplicação por completo?", "Encerrar aplicação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void tsbClients_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            
            Clients clients = new Clients();
            clients.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(clients);
            clients.Show();
        }

        private void tsbTickets_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Tickets tickets = new Tickets();
            tickets.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(tickets);
            tickets.Show();
        }
    }
}
