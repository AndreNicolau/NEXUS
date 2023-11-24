using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Settings : Form
    {
        Users _Users = new Users();

        public Settings()
        {
            InitializeComponent();
            _Users.LoadUsers(dataGridViewUsers);
        }

        private void LoadSettings()
        {
            string query = "SELECT * FROM customers";

            DataTable dataTable = new DataTable();

            using (OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS"))
            {

                try
                {
                    odbcConnection.Open();
                    OdbcDataAdapter adapter = new OdbcDataAdapter(query, odbcConnection);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _Users.InsertUser(textBoxUsername.Text, textBoxPassword.Text);
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxUsername.Focus();
            textBoxPassword.Clear();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            textBoxUsername.Text = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Tem a certeza que deseja elimninar este utilizador?", "Eliminar utilizador", MessageBoxButtons.YesNo);

            switch (message)
            {
                case DialogResult.Yes:
                    _Users.DeleteUser(textBoxUsername.Text);
                    _Users.LoadUsers(dataGridViewUsers);
                    break;
                case DialogResult.No:
                    return;
            }
        }
    }
}
