using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Equipment
    {
        OdbcConnection connection = new OdbcConnection("DSN=NEXUS");


        public void InsertEquipment(string Brand, string ModelName, string EquipmentType)
        {
            using (OdbcCommand command = new OdbcCommand($"INSERT INTO models (brand, model_name, equipment_type) VALUES ('{Brand}', '{ModelName}', '{EquipmentType}')", connection))
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Equipamento inserido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível inserir o equipamento! Erro: {ex.Message}");
                }
            }

            using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter($"SELECT * FROM brand_equipment WHERE brand = '{Brand}' AND equipment_type = '{EquipmentType}'", connection))
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        using (OdbcCommand command = new OdbcCommand($"INSERT INTO brand_equipment (brand, equipment_type) VALUES ('{Brand}', '{EquipmentType}')", connection))
                        {
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();

                                MessageBox.Show("Este tipo de equipamento não existia e foi adicionado à base de dados.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Erro ao inserir o equipamento! Erro: {ex.Message}");
                            }

                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao verificar se os equipamentos existem! Erro: {ex.Message}");
                }
            }
        }

        public void LoadModels(DataGridView dataGridView)
        {
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT brand AS 'Marca', model_name AS 'Modelo', equipment_type AS 'Tipo de equipamento' FROM models", connection))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível carregar os equipamentos! Erro: {ex.Message}");
                }
            }
        }

        public void LoadBrands(ComboBox comboBox)
        {
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM brands", connection))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = dataTable.Columns[0].ColumnName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível carregar as marcas! Erro: {ex.Message}");
                }
            }
        }

        public void LoadEquipments(ComboBox comboBox)
        {
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM equipments_types", connection))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = dataTable.Columns[0].ColumnName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível carregar os tipos de equipamentos! Erro: {ex.Message}");

                }
            }
        }

        public void DeleteEquipment(string ModelName)
        {
            using (OdbcCommand command = new OdbcCommand($"DELETE FROM models WHERE model_name = '{ModelName}'", connection))
            {
                DialogResult result = MessageBox.Show("Tem a certeza que deseja eliminar este equipamento?", "Eliminar equipamento", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Equipamento eliminado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não foi possível eliminar o equipamento! Erro: {ex.Message}");
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
