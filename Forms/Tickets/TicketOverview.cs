using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class TicketOverview : Form
    {
        Ticket _Ticket = new Ticket();
        public string TicketNumber;

        public TicketOverview(string ticketNumber, string customerId, string openDate, string brand, string model, string equipmentType, string serialNumber)
        {
            InitializeComponent();

            labelTicketNumber.Text = $"Número do ticket: {ticketNumber}";
            labelCustomerId.Text = $"Cliente associado: {customerId}";
            labelOpenDate.Text = $"Data de abertura: {openDate}";
            labelBrand.Text = $"Marca: {brand}";
            labelModel.Text = $"Modelo: {model}";
            labelEquipmentType.Text = $"Tipo de equipamento: {equipmentType}";
            labelSerialNumber.Text = $"Número de série: {serialNumber}";

            TicketNumber = ticketNumber;

            bool isTicketOpen = _Ticket.IsTicketOpen(ticketNumber);

            if (isTicketOpen == true)
            {
                buttonAddAction.Enabled = true;
                buttonCloseTicket.Enabled = true;
            } else
            {
                buttonAddAction.Enabled = false;
                buttonCloseTicket.Enabled = false;
            }

            LoadTicketActions();
        }

        private void LoadTicketActions()
        {
            dataGridViewActions.DataSource = _Ticket.LoadTicketActions(TicketNumber);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAction()
        {
            buttonInsertAction.Visible = true;
            buttonAddAction.Enabled = false;
            richTextBoxActions.ReadOnly = false;
            richTextBoxActions.Clear();
            richTextBoxActions.Focus();
        }

        private void buttonAddAction_Click(object sender, EventArgs e)
        {
            AddAction();
        }

        private void buttonInsertAction_Click(object sender, EventArgs e)
        {
            string description = richTextBoxActions.Text;
            _Ticket.InsertAction(TicketNumber, description);

            buttonAddAction.Enabled = true;
            buttonInsertAction.Visible = false;
            richTextBoxActions.ReadOnly = true;

            LoadTicketActions();
        }

        private void buttonCloseTicket_Click(object sender, EventArgs e)
        {
            _Ticket.CloseTicket(TicketNumber);
            this.Close();
        }

        private void dataGridViewActions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBoxActions.Text = dataGridViewActions.SelectedCells[0].Value.ToString();
        }
    }
}
