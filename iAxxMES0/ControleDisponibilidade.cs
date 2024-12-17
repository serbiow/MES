using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iAxxMES0
{
    public class ControleDisponibilidade
    {
        private MySqlConnection connection;

        public ControleDisponibilidade()
        {
            connection = Conexao.GetConnection();
        }

        // Método para adicionar uma indisponibilidade com Calendario_id
        public void AdicionarIndisponibilidade(Indisponibilidade indisponibilidade, int calendarioId)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = @"
                INSERT INTO indisponibilidade 
                (Calendario_id, DataEspecifica, HorarioInicio, HorarioFim, Motivo) 
                VALUES (@CalendarioId, @DataEspecifica, @HorarioInicio, @HorarioFim, @Motivo)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CalendarioId", calendarioId);
                    cmd.Parameters.AddWithValue("@DataEspecifica", indisponibilidade.DataEspecifica);
                    cmd.Parameters.AddWithValue("@HorarioInicio", indisponibilidade.HorarioInicio);
                    cmd.Parameters.AddWithValue("@HorarioFim", indisponibilidade.HorarioFim);
                    cmd.Parameters.AddWithValue("@Motivo", (object)indisponibilidade.Motivo ?? DBNull.Value);

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

        // Método para buscar todas as indisponibilidades de um Calendario específico
        public List<Indisponibilidade> BuscarIndisponibilidadesPorCalendario(int calendarioId)
        {
            List<Indisponibilidade> indisponibilidades = new List<Indisponibilidade>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM indisponibilidade WHERE Calendario_id = @CalendarioId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CalendarioId", calendarioId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var indisponibilidade = new Indisponibilidade
                            {
                                Id = reader.GetInt32("Id"),
                                DataEspecifica = reader.GetDateTime("DataEspecifica"),
                                HorarioInicio = reader.GetTimeSpan("HorarioInicio"),
                                HorarioFim = reader.GetTimeSpan("HorarioFim"),
                                Motivo = reader["Motivo"] != DBNull.Value ? reader.GetString("Motivo") : null
                            };
                            indisponibilidades.Add(indisponibilidade);
                        }
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

                string query = "DELETE FROM indisponibilidade WHERE Id = @Id";

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