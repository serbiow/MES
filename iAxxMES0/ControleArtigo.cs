using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class ControleArtigo
    {
        private MySqlConnection connection;

        public ControleArtigo()
        {
            connection = Conexao.GetConnection();
        }

        // Função de log para gravar erros
        private void LogError(string errorMessage)
        {
            string logFilePath = "C:/iAxx/log/error_log.txt"; // Caminho para o arquivo de log
            string logEntry = $"{DateTime.Now}: {errorMessage}\n"; // Log de erro com data e mensagem

            try
            {
                System.IO.File.AppendAllText(logFilePath, logEntry);
            }
            catch (Exception logEx)
            {
                Console.WriteLine($"Erro ao gravar no log: {logEx.Message}");
            }
        }

        // Método para adicionar um artigo
        public void AdicionarArtigo(string nome, int rpm_min, int rpm_max, string descricao = null)
        {
            string query = "INSERT INTO artigo (nome, rpm_min, rpm_max, descricao) VALUES (@nome, @rpm_min, @rpm_max, @descricao)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@rpm_min", rpm_min);
                    cmd.Parameters.AddWithValue("@rpm_max", rpm_max);
                    cmd.Parameters.AddWithValue("@descricao", descricao ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao adicionar artigo: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para editar um artigo
        public void EditarArtigo(int id, string novoNome, int novo_rpm_min, int novo_rpm_max, string novaDescricao = null)
        {
            string query = "UPDATE artigo SET nome = @novoNome, rpm_min = @novo_rpm_min, rpm_max = @novo_rpm_max, descricao = @novaDescricao WHERE id = @id";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@novoNome", novoNome);
                    cmd.Parameters.AddWithValue("@novo_rpm_min", novo_rpm_min);
                    cmd.Parameters.AddWithValue("@novo_rpm_max", novo_rpm_max);
                    cmd.Parameters.AddWithValue("@novaDescricao", novaDescricao ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao editar artigo com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para excluir um calendário
        public void ExcluirArtigo(int id)
        {
            string query = "DELETE FROM artigo WHERE id = @id";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao excluir artigo com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
