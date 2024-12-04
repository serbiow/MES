using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class ControleDisponibilidade
    {
        private MySqlConnection connection;

        public ControleDisponibilidade()
        {
            connection = Conexao.GetConnection();
        }

        // Método para adicionar uma indisponibilidade
        public void AdicionarIndisponibilidade(Indisponibilidade indisponibilidade)
        {
            try
            {
                // Verifica se a conexão está fechada antes de abri-la
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Query para inserir a indisponibilidade
                string query = @"
                INSERT INTO IndisponibilidadeMaquinas 
                (Tipo, DiaSemana, DataEspecifica, HorarioInicio, HorarioFim, Motivo) 
                VALUES (@Tipo, @DiaSemana, @DataEspecifica, @HorarioInicio, @HorarioFim, @Motivo)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Tipo", indisponibilidade.Tipo);
                    cmd.Parameters.AddWithValue("@DiaSemana", (object)indisponibilidade.DiaSemana ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataEspecifica", (object)indisponibilidade.DataEspecifica ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HorarioInicio", indisponibilidade.HorarioInicio);
                    cmd.Parameters.AddWithValue("@HorarioFim", indisponibilidade.HorarioFim);
                    cmd.Parameters.AddWithValue("@Motivo", indisponibilidade.Motivo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao adicionar indisponibilidade: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Método para buscar todas as indisponibilidades
        public List<Indisponibilidade> BuscarTodasIndisponibilidades()
        {
            List<Indisponibilidade> indisponibilidades = new List<Indisponibilidade>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM IndisponibilidadeMaquinas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var indisponibilidade = new Indisponibilidade
                        {
                            Id = reader.GetInt32("Id"),
                            Tipo = reader.GetString("Tipo"),
                            DiaSemana = reader["DiaSemana"] != DBNull.Value ? reader.GetString("DiaSemana") : null,
                            DataEspecifica = reader["DataEspecifica"] != DBNull.Value ? reader.GetDateTime("DataEspecifica") : (DateTime?)null,
                            HorarioInicio = reader.GetTimeSpan("HorarioInicio"),
                            HorarioFim = reader.GetTimeSpan("HorarioFim"),
                            Motivo = reader.GetString("Motivo")
                        };
                        indisponibilidades.Add(indisponibilidade);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao buscar indisponibilidades: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return indisponibilidades;
        }

        // Método para deletar uma indisponibilidade pelo ID
        public void DeletarIndisponibilidade(int id)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "DELETE FROM IndisponibilidadeMaquinas WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao deletar indisponibilidade: {ex.Message}");
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
