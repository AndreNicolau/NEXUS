using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public TicketOverview(string TicketNumber, string CustomerId, string OpenDate, string Brand, string Model, string EquipmentType)
        {
            InitializeComponent();

            labelTicketNumber.Text = $"Número do ticekt: {TicketNumber}";
            labelCustomerId.Text = $"Cliente associado: {CustomerId}";
            labelOpenDate.Text = $"Data de abertura: {OpenDate}";
            labelBrand.Text = $"Marca: {Brand}";
            labelModel.Text = $"Modelo: {Model}";
            labelEquipmentType.Text = $"Tipo de equipamento: {EquipmentType}";
        }
    }
}
