using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace iAxxMES0
{
    internal class ControleMaquinas
    {
        private MySqlConnection connection;

        public ControleMaquinas()
        {
            connection = Conexao.GetConnection();
        }

        // Método para obter todas as máquinas inicialmente
        public List<Maquina> ObterTodasMaquinas()
        {
            List<Maquina> maquinas = new List<Maquina>();
            string query = @"
            SELECT m.id, m.apelido, m.grupo, md.rpm, ms.descricao AS status, mp.descricao AS motivo_parada, md.comentario
            FROM maquina m
            JOIN (
                SELECT maquina_id, MAX(data_hora) AS max_data_hora
                FROM maquina_dados
                GROUP BY maquina_id
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON m.id = md.maquina_id AND md.data_hora = md_recent.max_data_hora
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            ORDER BY m.apelido";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            bool shouldCloseConnection = false;
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
                    Id = reader.GetInt32("id"),                       // Vem da tabela 'maquina'
                    Apelido = reader.GetString("apelido"),            // Vem da tabela 'maquina'
                    Grupo = reader.GetString("grupo"),                // Vem da tabela 'maquina'
                    RPM = reader.GetInt32("rpm"),                     // Vem da tabela 'maquina_dados'
                    Status = reader.GetString("status"),              // Vem da tabela 'maquina_dados'
                    // Verifica se 'motivo_parada' é NULL e atribui "parada não apontada" caso seja
                    Motivo_Parada = reader.IsDBNull(reader.GetOrdinal("motivo_parada")) ? "Parada não apontada" : reader.GetString("motivo_parada")
                };
                maquinas.Add(maquina);
            }

            reader.Close();

            if (shouldCloseConnection)
            {
                connection.Close();
            }

            return maquinas;
        }

        // Método assíncrono para obter os dados atualizados de cada máquina
        public async Task<List<Maquina>> ObterDadosAtualizadosAsync()
        {
            List<Maquina> maquinasAtualizadas = new List<Maquina>();
            string query = @"
            SELECT m.id, m.apelido, m.grupo, md.rpm, ms.descricao AS status, mp.descricao AS motivo_parada, md.comentario
            FROM maquina m
            JOIN (
                SELECT maquina_id, MAX(data_hora) AS max_data_hora
                FROM maquina_dados
                GROUP BY maquina_id
            ) md_recent ON m.id = md_recent.maquina_id
            JOIN maquina_dados md ON m.id = md.maquina_id AND md.data_hora = md_recent.max_data_hora
            LEFT JOIN maquina_status ms ON md.status = ms.id
            LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
            ORDER BY m.apelido";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Verificar se a conexão já está aberta antes de abri-la
            bool shouldCloseConnection = false;
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
                    Id = reader.GetInt32("id"),                       // Vem da tabela 'maquina'
                    Apelido = reader.GetString("apelido"),            // Vem da tabela 'maquina'
                    Grupo = reader.GetString("grupo"),                // Vem da tabela 'maquina'
                    RPM = reader.GetInt32("rpm"),                     // Vem da tabela 'maquina_dados'
                    Status = reader.GetString("status"),              // Vem da tabela 'maquina_dados'
                    // Verifica se 'motivo_parada' é NULL e atribui "parada não apontada" caso seja
                    Motivo_Parada = reader.IsDBNull(reader.GetOrdinal("motivo_parada")) ? "Parada não apontada" : reader.GetString("motivo_parada")
                };
                maquinasAtualizadas.Add(maquina);
            }

            reader.Close();

            // Fechar a conexão apenas se ela foi aberta nesta função
            if (shouldCloseConnection)
            {
                connection.Close();
            }

            return maquinasAtualizadas;
        }
    }
}
