using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;

namespace NEXUS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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

            dataGridView1.DataSource = dataTable;
        }

        private void SaveChanges()
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
