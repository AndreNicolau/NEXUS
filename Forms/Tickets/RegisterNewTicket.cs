using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class RegisterNewTicket : Form
    {
        private string CustomerId;
        private string CustomerName;

        Ticket _Ticket = new Ticket();

        public RegisterNewTicket()
        {
            InitializeComponent();

            labelDate.Text = $"Data: {DateTime.Today.ToString("yyyy/MM/dd")}";

            LoadBrands();
            LoadEquipments();
        }

        private void LoadBrands()
        {
            string brandQuery = $"SELECT * FROM brands";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(brandQuery, odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            comboBoxBrand.DataSource = dataTable;
            comboBoxBrand.DisplayMember = dataTable.Columns[0].ColumnName;
        }

        private void LoadEquipments()
        {
            string equipmentQuery = $"SELECT * FROM brand_equipment WHERE brand = '{comboBoxBrand.Text}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(equipmentQuery, odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            comboBoxEquipment.DataSource = dataTable;
            comboBoxEquipment.DisplayMember = ("equipment_type");
        }

        private void LoadModels()
        {
            string modelsQuery = $"SELECT * FROM models WHERE brand = '{comboBoxBrand.Text}' AND equipment_type = '{comboBoxEquipment.Text}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(modelsQuery, odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            comboBoxModel.DataSource = dataTable;
            comboBoxModel.DisplayMember = "model_name";
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAssociateCustomer_Click(object sender, EventArgs e)
        {
            using (var associateCustomer = new AssociateCustomer())
            {
                var result = associateCustomer.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CustomerId = associateCustomer.CustomerID;
                    CustomerName = associateCustomer.CustomerName;

                    labelAssociatedCustomer.Text = $"Cliente associado: {CustomerName}";
                }
            }
        }

        private void buttonRmoveCustomer_Click(object sender, EventArgs e)
        {
            labelAssociatedCustomer.Text = "Cliente associado: N/A";
            CustomerId = "1";
            CustomerName = "N/A";
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEquipments();
            LoadModels();
        }

        private void buttonInsertTicket_Click(object sender, EventArgs e)
        {
            if (CustomerId == null)
            { 
                CustomerId = "1";
            }
            /*
            string query = $"INSERT INTO tickets (open_date, associated_customer, equipment_brand, equipment_type, equipment_model, description) VALUES ('{DateTime.Today.ToString("yyyy / MM / dd")}',  '{Int32.Parse(CustomerId)}',  '{comboBoxBrand.Text}',  '{comboBoxEquipment.Text}',  '{comboBoxModel.Text}',  '{richTextBoxDescription.Text}')";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection);

            try
            {
                odbcConnection.Open();
                odbcCommand.ExecuteNonQuery();
                odbcConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível inserir o ticket devido ao erro {ex.Message}");
                return;
            }

            MessageBox.Show("Ticket inserido");
            this.Close();
            */

            string equipmentBrand = comboBoxBrand.Text;
            string equipmentType = comboBoxEquipment.Text;
            string equipmentModel = comboBoxModel.Text;
            string description = richTextBoxDescription.Text;

            _Ticket.InsertTicket(CustomerId, equipmentBrand, equipmentType, equipmentModel, description);

            this.Close();
        }

        private void comboBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModels();
        }
    }
}
