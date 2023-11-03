using System;
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
    public partial class TicketOverview : Form
    {
        public string TicketNumber;
        public string CustomerId;
        public string OpenDate;
        public string Brand;
        public string Model;
        public string EquipmentType;

        public TicketOverview(string ticketNumber, string customerId, string openDate, string brand, string model, string equipmentType)
        {
            InitializeComponent();

            labelTicketNumber.Text = $"Número do ticket: {ticketNumber}";
            labelCustomerId.Text = $"Cliente associado: {customerId}";
            labelOpenDate.Text = $"Data de abertura: {openDate}";
            labelBrand.Text = $"Marca: {brand}";
            labelModel.Text = $"Modelo: {model}";
            labelEquipmentType.Text = $"Tipo de equipamento: {equipmentType}";

            TicketNumber = ticketNumber;


            LoadTicketActions();
        }

        private void LoadTicketActions()
        {
            string brandQuery = $"SELECT * FROM ticket_actions WHERE associated_ticket_number = '{TicketNumber}'";

            OdbcConnection odbcConnection = new OdbcConnection("DSN=NEXUS");
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(brandQuery, odbcConnection);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            dataGridViewActions.DataSource = dataTable;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
