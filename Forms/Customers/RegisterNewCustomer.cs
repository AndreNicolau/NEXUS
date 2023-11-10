using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms.Customers
{
    public partial class RegisterNewCustomer : Form
    {
        public RegisterNewCustomer()
        {
            InitializeComponent();
        }

        private void InsertNewCustomer()
        {
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string taxpayerNumber = textBoxTaxPayerNumber.Text;
            string address = textBoxAddress.Text;

            Customer customer = new Customer();
            customer.InsertNewCustomer(name, phoneNumber, email, taxpayerNumber, address);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsertCustomer_Click(object sender, EventArgs e)
        {
            InsertNewCustomer();
        }
    }
}
