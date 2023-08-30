using NEXUS.Forms;
using System;
using System.Drawing;
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

        private void OpenClientsMain(object sender, EventArgs e)
        {
            ClientsMain clientsMain = new ClientsMain();
            mainPanel.Controls.Add(clientsMain);
            clientsMain.Dock = DockStyle.Fill;
            clientsMain.Show();
        }

        private void OpenClientSearch(object sender, EventArgs e)
        {
            ClientSearch clientSearch = new ClientSearch();
            clientSearch.Show();
        }

       
    }
}
