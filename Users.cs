using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS
{
    internal class Users
    {

        OdbcConnection _Connection = new OdbcConnection("DSN=NEXUS");

        public void InsertUser(string Username, string Password)
        {
            OdbcCommand command = new OdbcCommand($"INSERT INTO login (username, password) VALUES ({Username}, {Password})", _Connection);
            OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT * FROM login WHERE username = '{Username}'", _Connection);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show($"O utilizador {Username} já existe na base de dados.");
                return;
            }

            try
            {
                _Connection.Open();
                command.ExecuteNonQuery();
                _Connection.Close();

                MessageBox.Show($"Utilizador inserido na base de dados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir o utilizador! Erro: {ex.Message}");
                return;
            }
        }

        public void DeleteUser(string Username)
        {
            OdbcCommand command = new OdbcCommand($"DELETE FROM login WHERE username = '{Username}'", _Connection);

            try
            {
                _Connection.Open();
                command.ExecuteNonQuery();
                _Connection.Close();

                MessageBox.Show($"Utilizador {Username} eliminado.");
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar o utilizador! Erro: {ex.Message}");
            }
        }

        public void LoadUsers(DataGridView UsersDataGridView)
        {
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT user_id AS 'Número de utilizador', username AS 'Nome de utilizador', password AS 'Palavra-passe' FROM login", _Connection);
            DataTable usersDataTable = new DataTable();
            dataAdapter.Fill(usersDataTable);
            UsersDataGridView.DataSource = usersDataTable;
        }
    }
}
