using System;
using System.Windows.Forms;

namespace NEXUS.Forms.Tickets
{
    public partial class TicketOverview : Form
    {
        Ticket _Ticket = new Ticket();

        public string TicketNumber;
        public string CustomerId;
        public string OpenDate;
        public string Brand;
        public string Model;
        public string EquipmentType;

        private bool AddingAction = false;

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
            dataGridViewActions.DataSource = _Ticket.LoadTicketActions(TicketNumber);
        }

        private void UpdateRichTextBox()
        {
            richTextBoxActions.Text = dataGridViewActions.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAction()
        {
            if (AddingAction == false)
            {
                richTextBoxActions.Clear();
                richTextBoxActions.Focus();
                buttonAddAction.Text = "Inserir";
                buttonAddAction.Image = Properties.Resources.disk_icon_24px;
                dataGridViewActions.Enabled = false;
                AddingAction = true;
            }
            else
            {
                LoadTicketActions();
                buttonAddAction.Text = "Adicionar ação";
                buttonAddAction.Image = Properties.Resources.add_icon_24px;
                dataGridViewActions.Enabled = true;
                dataGridViewActions.Focus();
                UpdateRichTextBox();
                AddingAction = false;
            }
        }

        private void dataGridViewActions_SelectionChanged(object sender, EventArgs e)
        {
            UpdateRichTextBox();
        }

        private void buttonAddAction_Click(object sender, EventArgs e)
        {
            AddAction();
        }
    }
}
