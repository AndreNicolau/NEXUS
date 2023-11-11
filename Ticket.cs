using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Ticket
    {
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");

        public void InsertTicket(string AssociatedCustomer, string EquipmentBrand, string EquipmentType, string EquipmentModel, string Description)
        {
            string date = DateTime.Today.ToString("yyyy/MM/dd");
            OdbcCommand command = new OdbcCommand($"INSERT INTO tickets (open_date, associated_customer, equipment_brand, equipment_type, equipment_model, description) VALUES ('{date}', '{AssociatedCustomer}', '{EquipmentBrand}', '{EquipmentType}', '{EquipmentModel}', '{Description}') ", connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ticket inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
