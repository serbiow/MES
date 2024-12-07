using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class ControleCalendario
    {
        private MySqlConnection connection;

        public ControleCalendario()
        {
            connection = Conexao.GetConnection();
        }

        // Função de log para gravar erros
        private void LogError(string errorMessage)
        {
            string logFilePath = "error_log.txt"; // Caminho para o arquivo de log
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

        // Método para obter todos os calendários
        public List<Calendario> ObterTodosCalendaris()
        {
            List<Calendario> calendarios = new List<Calendario>();
            string query = "SELECT id, nome, descricao FROM calendario";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Calendario calendario = new Calendario
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao")
                        };
                        calendarios.Add(calendario);
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter todos os calendarios: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return calendarios;
        }

        // Método para obter todas as máquinas de um calandário específico
        public List<Maquina> ObterMaquinasDoCalendario(int calendarioId)
        {
            List<Maquina> maquinas = new List<Maquina>();
            string query = @"
            SELECT m.id, m.apelido, m.finura, m.diametro, m.numero_alimentadores, m.calendario_id
            FROM maquina m
            JOIN calendario c ON m.calendario_id = c.id
            WHERE c.id = @calendarioId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@calendarioId", calendarioId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Maquina maquina = new Maquina
                            {
                                Id = reader.GetInt32("id"),
                                Apelido = reader.GetString("apelido"),
                                Finura = reader.GetInt32("finura"),
                                Diametro = reader.GetInt32("diametro"),
                                NumeroAlimentadores = reader.GetInt32("numero_alimentadores"),
                                Calendario = reader.GetInt32("calendario_id")
                            };
                            maquinas.Add(maquina);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter máquinas do calendário {calendarioId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return maquinas;
        }

        // Método para adicionar um calendário
        public void AdicionarCalendario(string nome, string descricao = null)
        {
            string query = "INSERT INTO calendario (nome, descricao) VALUES (@nome, @descricao)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@descricao", descricao ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao adicionar calendário: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para editar um calendario
        public void EditarCalendario(int id, string novoNome, string novaDescricao = null)
        {
            string query = "UPDATE calendario SET nome = @novoNome, descricao = @novaDescricao WHERE id = @id";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@novoNome", novoNome);
                    cmd.Parameters.AddWithValue("@novaDescricao", novaDescricao ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao editar calendario com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para excluir um calendário
        public void ExcluirCalendario(int id)
        {
            string query = "DELETE FROM calendario WHERE id = @id";

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
                LogError($"Erro ao excluir calendario com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para associar máquinas a um calendário específico
        public void AssociarMaquinaAoCalendario(int maquinaId, int calendarioId)
        {
            string query = "UPDATE maquina SET calendario_id = @calendarioId WHERE id = @maquinaId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);
                    cmd.Parameters.AddWithValue("@calendarioId", calendarioId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao associar máquina {maquinaId} ao calendário {calendarioId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para remover uma máquina de um calendário
        public void RemoverMaquinaDoCalendario(int maquinaId)
        {
            string query = "UPDATE maquina SET calendario_id = NULL WHERE id = @maquinaId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao remover a máquina {maquinaId} do calendário: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para remover todas as máquinas de um calendário
        public void RemoverTodasMaquinasDoCalendario(int calendarioId)
        {
            string query = "UPDATE maquina SET calendario_id = NULL WHERE calendario_id = @calendarioId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@calendarioId", calendarioId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao remover todas as máquinas do calendário {calendarioId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
