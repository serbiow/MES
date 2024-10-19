using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class ControleMaquinas
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
            SELECT m.id, m.apelido, m.grupo, m.finura, m.diametro, m.numero_alimentadores, md.rpm, ms.descricao AS status,
            mp.descricao AS motivo_parada, md.comentario, md.data_hora
            FROM maquina m
            JOIN (
                SELECT maquina_id, MAX(id) AS max_id
                FROM maquina_dados
                WHERE (maquina_id, data_hora) IN (
                    SELECT maquina_id, MAX(data_hora)
                    FROM maquina_dados
                    GROUP BY maquina_id
                )
                GROUP BY maquina_id
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON md.id = md_recent.max_id
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            ORDER BY m.apelido;";

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
                        Grupo = reader.GetString("grupo"),
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

        // Método assíncrono para obter os dados atualizados de cada máquina
        public async Task<List<Maquina>> ObterDadosAtualizadosAsync()
        {
            List<Maquina> maquinasAtualizadas = new List<Maquina>();
            string query = @"
            SELECT m.id, m.apelido, m.grupo, m.finura, m.diametro, m.numero_alimentadores, md.rpm, ms.descricao AS status,
            mp.descricao AS motivo_parada, md.comentario, md.data_hora
            FROM maquina m
            JOIN (
                SELECT maquina_id, MAX(id) AS max_id
                FROM maquina_dados
                WHERE (maquina_id, data_hora) IN (
                    SELECT maquina_id, MAX(data_hora)
                    FROM maquina_dados
                    GROUP BY maquina_id
                )
                GROUP BY maquina_id
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON md.id = md_recent.max_id
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            ORDER BY m.apelido;";

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
                        Grupo = reader.GetString("grupo"),
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
    }
}
