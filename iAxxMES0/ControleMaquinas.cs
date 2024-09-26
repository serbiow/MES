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
            SELECT m.id, m.apelido, md.rpm, md.status 
            FROM maquina m
            JOIN maquina_dados md ON m.id = md.maquina_id
            WHERE md.data_hora = (
                SELECT MAX(md2.data_hora) 
                FROM maquina_dados md2 
                WHERE md2.maquina_id = m.id
            )
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
                    Id = reader.GetInt32("id"),
                    Apelido = reader.GetString("apelido"),
                    RPM = reader.GetInt32("rpm"),
                    Status = reader.GetString("status")
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
            SELECT m.id, m.apelido, md.rpm, md.status 
            FROM maquina m
            JOIN maquina_dados md ON m.id = md.maquina_id
            WHERE md.data_hora = (
                SELECT MAX(md2.data_hora) 
                FROM maquina_dados md2 
                WHERE md2.maquina_id = m.id
            )
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
                    Id = reader.GetInt32("id"),            // Vem da tabela 'maquina'
                    Apelido = reader.GetString("apelido"), // Vem da tabela 'maquina'
                    RPM = reader.GetInt32("rpm"),          // Vem da tabela 'maquina_dados'
                    Status = reader.GetString("status")    // Vem da tabela 'maquina_dados'
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
