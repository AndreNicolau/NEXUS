using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class RegisterNewTicket : Form
    {
        private string CustomerId;
        private string CustomerName;

        public RegisterNewTicket()
        {
            InitializeComponent();

            labelDate.Text = $"Data: {DateTime.Today.ToString("yyyy/MM/dd")}";

            LoadDataFromTable("equipments_types", comboBoxEquipment);
            LoadDataFromTable("brands", comboBoxBrand);
        }

        private void LoadDataFromTable(string tableName, ComboBox comboBoxName)
        {
            string equipmentQuery = $"SELECT * FROM {tableName}";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(equipmentQuery, odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            comboBoxName.DataSource = dataTable;
            comboBoxName.DisplayMember = dataTable.Columns[0].ColumnName;
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
            labelAssociatedCustomer.Text = "Cliente associado: Nenhum cliente associado";
            CustomerId = string.Empty;
            CustomerName = string.Empty;
        }
    }
}
