using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS
{
    public partial class ClientsMain : UserControl
    {
        public ClientsMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "search")
                {
                    control.Enabled = true;
                }
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
           
            string fetchClientsCommand = "SELECT * FROM clients";

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=nexus;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter(fetchClientsCommand, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvClients.DataSource = dataTable;

              
            }
            catch (Exception ex)
            {
                string message = $"Não foi possível obter os dados dos clientes a partir da base de dados! Erro: \n{ex}";
                string caption = $"Erro ao obter os dados dos clientes!";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void txtSearcBar_Enter(object sender, EventArgs e)
        {
            if (txtSearcBar.Text == "Nome, email, telemóvel, contribuinte")
                txtSearcBar.Clear();
        }

        private void txtSearcBar_Leave(object sender, EventArgs e)
        {
            if (txtSearcBar.Text == "")
                txtSearcBar.Text = "Nome, email, telemóvel, contribuinte";
        }
    }
}
