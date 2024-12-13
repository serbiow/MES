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
            string logFilePath = "C:/iAxxMES/log/error_log.txt"; // Caminho para o arquivo de log
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

        // Método para obter todos os artigos
        public List<Artigo> ObterTodosArtigos()
        {
            List<Artigo> artigos = new List<Artigo>();
            string query = @"
                            SET SESSION group_concat_max_len = 10000;
                            SELECT 
                                a.id AS artigo_id,
                                a.nome AS artigo_nome,
                                a.descricao,
                                a.rpm_min,
                                a.rpm_max,
                                a.rpm_media,
                                GROUP_CONCAT(CONCAT(f.nome, ' (', ca.porcentagem, '%)') SEPARATOR ', ') AS composicao
                            FROM 
                                artigo a
                            JOIN 
                                composicao_artigo ca ON a.id = ca.artigo_id
                            JOIN 
                                fibras f ON ca.fibra_id = f.id
                            GROUP BY 
                                a.id, a.nome, a.descricao, a.rpm_min, a.rpm_max, a.rpm_media;";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Artigo artigo = new Artigo
                        {
                            Id = reader.GetInt32("artigo_id"),
                            Nome = reader.GetString("artigo_nome"),
                            Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao"),
                            RPM_Min = reader.GetInt32("rpm_min"),
                            RPM_Max = reader.GetInt32("rpm_max"),
                            RPM_Media = reader.GetInt32("rpm_media"),
                            Composicao = reader.IsDBNull(reader.GetOrdinal("composicao")) ? null : reader.GetString("composicao")
                        };
                        artigos.Add(artigo);
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter todos os artigos: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return artigos;
        }

        //Método para obter o artigo pelo nome dele
        public List<Artigo> ObterArtigosPorNome(string nome)
        {
            List<Artigo> artigos = new List<Artigo>();
            string query = @"SET SESSION group_concat_max_len = 10000;
                            SELECT 
                                a.id AS artigo_id,
                                a.nome AS artigo_nome,
                                a.descricao,
                                a.rpm_min,
                                a.rpm_max,
                                a.rpm_media,
                                GROUP_CONCAT(CONCAT(f.nome, ' (', ca.porcentagem, '%)') SEPARATOR ', ') AS composicao
                            FROM 
                                artigo a
                            JOIN 
                                composicao_artigo ca ON a.id = ca.artigo_id
                            JOIN 
                                fibras f ON ca.fibra_id = f.id
                            WHERE 
                                a.nome LIKE @nome
                            GROUP BY 
                                a.id, a.nome, a.descricao, a.rpm_min, a.rpm_max, a.rpm_media;";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Usando LIKE para permitir busca parcial
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Artigo artigo = new Artigo
                            {
                                Id = reader.GetInt32("artigo_id"),
                                Nome = reader.GetString("artigo_nome"),
                                Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao"),
                                RPM_Min = reader.GetInt32("rpm_min"),
                                RPM_Max = reader.GetInt32("rpm_max"),
                                RPM_Media = reader.GetInt32("rpm_media"),
                                Composicao = reader.IsDBNull(reader.GetOrdinal("composicao")) ? null : reader.GetString("composicao")
                            };
                            artigos.Add(artigo);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao buscar artigos com nome '{nome}': {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return artigos;
        }

        // Método para obter todas as fibras de um artigo específico
        public List<Fibra> ObterFibrasDoArtigo(int artigoId)
        {
            List<Fibra> fibras = new List<Fibra>();
            string query = @"SELECT 
                                f.id AS fibra_id,
                                f.nome AS fibra_nome
                            FROM 
                                fibras f
                            JOIN 
                                composicao_artigo ca ON f.id = ca.fibra_id
                            WHERE 
                                ca.artigo_id = @artigoId;";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@artigoId", artigoId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fibra fibra = new Fibra
                            {
                                Id = reader.GetInt32("fibra_id"),
                                Nome = reader.GetString("fibra_nome")
                            };
                            fibras.Add(fibra);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter fibras do artigo {artigoId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return fibras;
        }

        // Método para adicionar um artigo
        public void AdicionarArtigo(string nome, int rpm_min, int rpm_max, List<(int fibraId, decimal porcentagem)> composicao, string descricao = null)
        {
            string artigoQuery = "INSERT INTO artigo (nome, rpm_min, rpm_max, descricao) VALUES (@nome, @rpm_min, @rpm_max, @descricao)";
            string composicaoQuery = "INSERT INTO composicao_artigo (artigo_id, fibra_id, porcentagem) VALUES (@artigo_id, @fibra_id, @porcentagem)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                // Inserir o artigo
                using (MySqlCommand cmd = new MySqlCommand(artigoQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@rpm_min", rpm_min);
                    cmd.Parameters.AddWithValue("@rpm_max", rpm_max);
                    cmd.Parameters.AddWithValue("@descricao", descricao ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }

                // Recuperar o ID do artigo recém-inserido
                ulong artigoId;
                using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", connection))
                {
                    artigoId = (ulong)cmd.ExecuteScalar();
                }

                // Inserir a composição na tabela composicao_artigo
                foreach (var item in composicao)
                {
                    using (MySqlCommand cmd = new MySqlCommand(composicaoQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@artigo_id", (int)artigoId); // Converte para int
                        cmd.Parameters.AddWithValue("@fibra_id", item.fibraId);
                        cmd.Parameters.AddWithValue("@porcentagem", item.porcentagem);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao adicionar artigo e sua composição: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para editar um artigo
        public void EditarArtigo(int id, string novoNome, int novo_rpm_min, int novo_rpm_max, string novaDescricao, List<(int fibraId, decimal porcentagem)> composicao)
        {
            string queryUpdateArtigo = @"UPDATE artigo 
                                  SET nome = @novoNome, 
                                      rpm_min = @novo_rpm_min, 
                                      rpm_max = @novo_rpm_max, 
                                      descricao = @novaDescricao 
                                  WHERE id = @id";

            string queryDeleteComposicao = "DELETE FROM composicao_artigo WHERE artigo_id = @id";

            string queryInsertComposicao = "INSERT INTO composicao_artigo (artigo_id, fibra_id, porcentagem) VALUES (@id, @fibraId, @porcentagem)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    // Atualizar os dados do artigo
                    using (MySqlCommand cmd = new MySqlCommand(queryUpdateArtigo, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@novoNome", novoNome);
                        cmd.Parameters.AddWithValue("@novo_rpm_min", novo_rpm_min);
                        cmd.Parameters.AddWithValue("@novo_rpm_max", novo_rpm_max);
                        cmd.Parameters.AddWithValue("@novaDescricao", novaDescricao ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    // Deletar a composição antiga
                    using (MySqlCommand cmd = new MySqlCommand(queryDeleteComposicao, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    // Inserir a nova composição
                    foreach (var (fibraId, porcentagem) in composicao)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(queryInsertComposicao, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@fibraId", fibraId);
                            cmd.Parameters.AddWithValue("@porcentagem", porcentagem);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Commitar a transação se tudo ocorrer sem erros
                    transaction.Commit();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao editar artigo com ID {id}: {ex.Message}");
            }
            catch (Exception ex)
            {
                LogError($"Erro inesperado ao editar artigo com ID {id}: {ex.Message}");
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

        // Método para buscar fibras
        public List<Fibra> BuscarFibras()
        {
            string query = "SELECT id AS fibra_id, nome AS fibra_nome FROM fibras ORDER BY nome asc";
            List<Fibra> fibras = new List<Fibra>();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fibra fibra = new Fibra
                        {
                            Id = reader.GetInt32("fibra_id"),
                            Nome = reader.GetString("fibra_nome")
                        };
                        fibras.Add(fibra);
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao buscar fibras: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return fibras;
        }

    }
}
