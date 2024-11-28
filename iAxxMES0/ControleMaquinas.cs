using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class ControleMaquinas
    {
        private MySqlConnection connection;

        public ControleMaquinas()
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

        // Método para obter todas as máquinas inicialmente
        public List<Maquina> ObterTodasMaquinas()
        {
            List<Maquina> maquinas = new List<Maquina>();
            string query = @"
            SELECT 
                m.id,
                m.apelido, 
                GROUP_CONCAT(g.nome SEPARATOR ', ') AS grupos, -- Concatenar todos os grupos em uma única coluna
                m.finura, 
                m.diametro, 
                m.numero_alimentadores, 
                md.rpm, 
                ms.descricao AS status,
                mp.descricao AS motivo_parada, 
                md.comentario, 
                md.data_hora
            FROM 
                maquina m
            JOIN grupo_maquina gm ON m.id = gm.maquina_id
            JOIN grupo g ON gm.grupo_id = g.id
            JOIN (
                SELECT 
                    md1.maquina_id, 
                    md1.id AS max_id
                FROM 
                    maquina_dados md1
                JOIN (
                    SELECT 
                        maquina_id, 
                        MAX(data_hora) AS max_data_hora
                    FROM 
                        maquina_dados
                    GROUP BY 
                        maquina_id
                ) md2 
                ON md1.maquina_id = md2.maquina_id AND md1.data_hora = md2.max_data_hora
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON md.id = md_recent.max_id
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            GROUP BY 
                m.id, md.id, ms.descricao, mp.descricao
            ORDER BY 
                m.apelido;";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 5; // Timeout da consulta para evitar congelamentos

            bool shouldCloseConnection = false;

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    shouldCloseConnection = true;
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Maquina maquina = new Maquina
                    {
                        Id = reader.GetInt32("id"),
                        Apelido = reader.GetString("apelido"),
                        Grupo = reader.GetString("grupos"),
                        RPM = reader.GetInt32("rpm"),
                        Status = reader.GetString("status"),
                        Motivo_Parada = reader.IsDBNull(reader.GetOrdinal("motivo_parada")) ? "Parada não apontada" : reader.GetString("motivo_parada"),
                        Diametro = reader.GetInt32("diametro"),
                        Finura = reader.GetInt32("finura"),
                        NumeroAlimentadores = reader.GetInt32("numero_alimentadores"),
                        DataHoraStatus = reader.GetDateTime("data_hora")
                    };
                    maquinas.Add(maquina);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter todas as máquinas: {ex.Message}");
            }
            finally
            {
                if (shouldCloseConnection && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return maquinas;
        }

        // Método para obter as máquina de forma simplificada (apenas id e apelido)
        public List<Maquina> ObterMaquinasSimplificado()
        {
            List<Maquina> maquinas = new List<Maquina>();
            string query = "SELECT id, apelido FROM maquina";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Maquina maquina = new Maquina
                        {
                            Id = reader.GetInt32("id"),
                            Apelido = reader.GetString("apelido")
                        };
                        maquinas.Add(maquina);
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter lista simplificada de máquinas: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return maquinas;
        }

        // Método assíncrono para obter os dados atualizados de cada máquina
        public async Task<List<Maquina>> ObterDadosAtualizadosAsync()
        {
            List<Maquina> maquinasAtualizadas = new List<Maquina>();
            string query = @"
            SELECT 
                m.id,
                m.apelido, 
                GROUP_CONCAT(g.nome SEPARATOR ', ') AS grupos, -- Concatenar todos os grupos em uma única coluna
                m.finura, 
                m.diametro, 
                m.numero_alimentadores, 
                md.rpm, 
                ms.descricao AS status,
                mp.descricao AS motivo_parada, 
                md.comentario, 
                md.data_hora
            FROM 
                maquina m
            JOIN grupo_maquina gm ON m.id = gm.maquina_id
            JOIN grupo g ON gm.grupo_id = g.id
            JOIN (
                SELECT 
                    md1.maquina_id, 
                    md1.id AS max_id
                FROM 
                    maquina_dados md1
                JOIN (
                    SELECT 
                        maquina_id, 
                        MAX(data_hora) AS max_data_hora
                    FROM 
                        maquina_dados
                    GROUP BY 
                        maquina_id
                ) md2 
                ON md1.maquina_id = md2.maquina_id AND md1.data_hora = md2.max_data_hora
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON md.id = md_recent.max_id
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            GROUP BY 
                m.id, md.id, ms.descricao, mp.descricao
            ORDER BY 
                m.apelido;";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 5; // Timeout da consulta assíncrona

            bool shouldCloseConnection = false;

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    shouldCloseConnection = true;
                }

                MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Maquina maquina = new Maquina
                    {
                        Id = reader.GetInt32("id"),
                        Apelido = reader.GetString("apelido"),
                        Grupo = reader.GetString("grupos"),
                        RPM = reader.GetInt32("rpm"),
                        Status = reader.GetString("status"),
                        Motivo_Parada = reader.IsDBNull(reader.GetOrdinal("motivo_parada")) ? "Parada não apontada" : reader.GetString("motivo_parada"),
                        Diametro = reader.GetInt32("diametro"),
                        Finura = reader.GetInt32("finura"),
                        NumeroAlimentadores = reader.GetInt32("numero_alimentadores"),
                        DataHoraStatus = reader.GetDateTime("data_hora")
                    };
                    maquinasAtualizadas.Add(maquina);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter dados atualizados: {ex.Message}");
            }
            finally
            {
                if (shouldCloseConnection && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return maquinasAtualizadas;
        }

        public void EditarMaquina(int maquinaId, int finura, int numeroAlimentadores, int diametro, string apelido)
        {
            string query = @"
            UPDATE maquina 
            SET finura = @finura, 
                numero_alimentadores = @numeroAlimentadores, 
                diametro = @diametro, 
                apelido = @apelido 
            WHERE id = @maquinaId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);
                    cmd.Parameters.AddWithValue("@finura", finura);
                    cmd.Parameters.AddWithValue("@numeroAlimentadores", numeroAlimentadores);
                    cmd.Parameters.AddWithValue("@diametro", diametro);
                    cmd.Parameters.AddWithValue("@apelido", apelido);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao editar máquina com ID {maquinaId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public List<Tuple<DateTime, int>> ObterHistoricoRPMMaquina(int maquinaId)
        {
            List<Tuple<DateTime, int>> dadosHistorico = new List<Tuple<DateTime, int>>();

            string query = @"
            SELECT data_hora, rpm
            FROM maquina_dados
            WHERE maquina_id = @maquinaId
            AND data_hora >= NOW() - INTERVAL 1 HOUR
            ORDER BY data_hora ASC";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dataHora = reader.GetDateTime("data_hora");
                            int rpm = reader.GetInt32("rpm");
                            dadosHistorico.Add(new Tuple<DateTime, int>(dataHora, rpm));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o histórico de rpm: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dadosHistorico;
        }

        // Método para testar se a conexão com o banco está ativa
        public void TestarConexao()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao testar a conexão com o banco: {ex.Message}");
                throw; // Lançar exceção para indicar falha na conexão
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Controle dos Grupos

        // Método para obter todos os grupos
        public List<Grupo> ObterTodosGrupos()
        {
            List<Grupo> grupos = new List<Grupo>();
            string query = "SELECT id, nome, descricao FROM grupo";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grupo grupo = new Grupo
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao")
                        };
                        grupos.Add(grupo);
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter todos os grupos: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return grupos;
        }

        //Método para obter a máquina pelo apelido dela
        public Maquina ObterMaquinaPorApelido(string apelido)
        {
            Maquina maquina = null;
            string query = "SELECT id, apelido, finura, diametro, numero_alimentadores FROM maquina WHERE apelido = @apelido LIMIT 1";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@apelido", apelido);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maquina = new Maquina
                            {
                                Id = reader.GetInt32("id"),
                                Apelido = reader.GetString("apelido"),
                                Finura = reader.GetInt32("finura"),
                                Diametro = reader.GetInt32("diametro"),
                                NumeroAlimentadores = reader.GetInt32("numero_alimentadores")
                            };
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter máquina com apelido '{apelido}': {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return maquina;
        }

        // Método para adicionar um grupo
        public void AdicionarGrupo(string nome, string descricao = null)
        {
            string query = "INSERT INTO grupo (nome, descricao) VALUES (@nome, @descricao)";

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
                LogError($"Erro ao adicionar grupo: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para editar um grupo
        public void EditarGrupo(int id, string novoNome, string novaDescricao = null)
        {
            string query = "UPDATE grupo SET nome = @novoNome, descricao = @novaDescricao WHERE id = @id";

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
                LogError($"Erro ao editar grupo com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para excluir um grupo
        public void ExcluirGrupo(int id)
        {
            string query = "DELETE FROM grupo WHERE id = @id";

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
                LogError($"Erro ao excluir grupo com ID {id}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para associar uma máquina a um grupo
        public void AssociarMaquinaAoGrupo(int grupoId, int maquinaId)
        {
            string query = "INSERT IGNORE INTO grupo_maquina (grupo_id, maquina_id) VALUES (@grupoId, @maquinaId)";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao associar máquina {maquinaId} ao grupo {grupoId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para remover uma máquina de um grupo
        public void RemoverMaquinaDoGrupo(int grupoId, int maquinaId)
        {
            string query = "DELETE FROM grupo_maquina WHERE grupo_id = @grupoId AND maquina_id = @maquinaId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    cmd.Parameters.AddWithValue("@maquinaId", maquinaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao remover máquina {maquinaId} do grupo {grupoId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Método para obter todas as máquinas de um grupo específico
        public List<Maquina> ObterMaquinasDoGrupo(int grupoId)
        {
            List<Maquina> maquinas = new List<Maquina>();
            string query = @"
            SELECT m.id, m.apelido, m.finura, m.diametro, m.numero_alimentadores
            FROM maquina m
            JOIN grupo_maquina gm ON m.id = gm.maquina_id
            WHERE gm.grupo_id = @grupoId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);

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
                                NumeroAlimentadores = reader.GetInt32("numero_alimentadores")
                            };
                            maquinas.Add(maquina);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao obter máquinas do grupo {grupoId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return maquinas;
        }

        // Método para remover todas as maáquinas de um grupo selecionado
        public void RemoverTodasMaquinasDoGrupo(int grupoId)
        {
            string query = "DELETE FROM grupo_maquina WHERE grupo_id = @grupoId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LogError($"Erro ao remover todas as máquinas do grupo {grupoId}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
