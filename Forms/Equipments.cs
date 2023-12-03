using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Equipments : Form
    {
        Equipment _Equipment = new Equipment();

        public Equipments()
        {
            InitializeComponent();

            _Equipment.LoadModels(dataGridViewModels);
            _Equipment.LoadEquipments(comboBoxEquipmentType);
            _Equipment.LoadBrands(comboBoxBrand);
        }

        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {
            comboBoxBrand.Text = string.Empty;
            comboBoxEquipmentType.Text = string.Empty;
            textBoxModel.Clear();
        }

        private void buttonRemoveEquipment_Click(object sender, EventArgs e)
        {
            string Model = textBoxModel.Text;
            _Equipment.DeleteEquipment(Model);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string Brand = comboBoxBrand.Text;
            string Model = textBoxModel.Text;
            string EquipmentType = comboBoxEquipmentType.Text;

            if (Brand == string.Empty || Model == string.Empty || EquipmentType == string.Empty)
            {
                MessageBox.Show("É necessário que todos os campos estejam preenchidos!");
                return;
            }

            _Equipment.InsertEquipment(Brand, Model, EquipmentType);
            _Equipment.LoadModels(dataGridViewModels);
        }
    }
}
