using System;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {

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
    }
}
