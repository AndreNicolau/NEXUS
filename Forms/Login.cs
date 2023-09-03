using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                MessageBox.Show("É necessário preencher o nome de utilizador.", "Utilizador em branco.");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("É necessário preencher a password.", "Password em branco");
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM login WHERE username = '{username}'", connection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Utilizador não encontrado.", "Utilizador inválido.");
            }
            else if (dataTable.Rows[0][2].ToString() != password)
            {
                MessageBox.Show("Password errada!", "Password inválida");
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void Login_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Alt)
            {
                Settings settings = new Settings();
                settings.Show();
                this.Hide();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
