using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class Conexao
    {
        private static MySqlConnection connection;
        private static string connectionString = "server=localhost;port=3306;database=iaxxmes;uid=root;pwd=;";

        // Método que retorna a instância única de conexão
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MessageBox.Show("Conexão com o banco de dados foi aberta com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao abrir a conexão: {ex.Message}");
                }
            }

            return connection;
        }

        // Método para fechar a conexão (se necessário)
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexão com o banco de dados foi fechada com sucesso!");
            }
        }
    }
}
