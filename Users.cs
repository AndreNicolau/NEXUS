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
        // Ligação à base de dados
        OdbcConnection _Connection = new OdbcConnection("DSN=NEXUS");

        // Método para inserir um novo utilzador na base de dados
        public void InsertUser(string Username, string Password)
        {
            // Comando para inserir um novo utilzador
            OdbcCommand command = new OdbcCommand($"INSERT INTO login (username, password) VALUES ({Username}, {Password})", _Connection);
            OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT * FROM login WHERE username = '{Username}'", _Connection);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            // Verificação se o utilizador é existente
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show($"O utilizador {Username} já existe na base de dados.");
                return;
            }

            // Execução do comando
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

        // Método para eliminar um utilizador da base de dados
        public void DeleteUser(string Username)
        {
            // Comando para eliminar um utilizador
            OdbcCommand command = new OdbcCommand($"DELETE FROM login WHERE username = '{Username}'", _Connection);

            // Execução do comando
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

        // Método para carregar todos os utilizadores para uma DataGridView
        public void LoadUsers(DataGridView UsersDataGridView)
        {
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT user_id AS 'Número de utilizador', username AS 'Nome de utilizador', password AS 'Palavra-passe' FROM login", _Connection);
            DataTable usersDataTable = new DataTable();
            dataAdapter.Fill(usersDataTable);
            UsersDataGridView.DataSource = usersDataTable;
        }
    }
}
