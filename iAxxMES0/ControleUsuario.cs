using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class ControleUsuario
    {
        private MySqlConnection connection;

        public ControleUsuario()
        {
            connection = Conexao.GetConnection();
        }

        // Método para validar o login
        public bool ValidarLogin(string loginNome, string senha)
        {
            try
            {
                // Verifica se a conexão está fechada antes de abri-la
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Consulta ao banco de dados para verificar o login
                string query = "SELECT senha FROM login WHERE login_nome = @login_nome";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@login_nome", loginNome);

                // Executar a consulta e pegar o hash armazenado
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hashArmazenado = reader.GetString("senha");
                    reader.Close();

                    // Verificar se a senha digitada corresponde ao hash armazenado
                    return HashHelper.VerificarSenha(senha, hashArmazenado);
                }
                else
                {
                    reader.Close();
                    return false; // Login não encontrado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar o login: {ex.Message}");
                return false;
            }
            finally
            {
                // Garantir que a conexão seja fechada após a operação
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Método para inserir um novo usuário
        public void InserirUsuario(Usuario usuario, Login login)
        {
            MySqlTransaction transaction = null;
            try
            {
                // Verifica se a conexão está fechada antes de abri-la
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Iniciar uma transação
                transaction = connection.BeginTransaction();

                // Inserir o usuário
                string queryUsuario = "INSERT INTO usuario (nome, cargo, horario, cpf) VALUES (@nome, @cargo, @horario, @cpf)";
                MySqlCommand cmd = new MySqlCommand(queryUsuario, connection, transaction);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                cmd.Parameters.AddWithValue("@horario", usuario.Horario);
                cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                cmd.ExecuteNonQuery();

                // Obter o ID do usuário recém-criado
                int usuarioId = (int)cmd.LastInsertedId;

                // Gerar o hash da senha
                string senhaHashed = HashHelper.GerarHashComSalt(login.Senha);

                // Inserir login e senha
                string queryLogin = "INSERT INTO login (usuario_id, login_nome, senha) VALUES (@usuario_id, @login_nome, @senha)";
                cmd = new MySqlCommand(queryLogin, connection, transaction);
                cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                cmd.Parameters.AddWithValue("@login_nome", login.LoginNome);
                cmd.Parameters.AddWithValue("@senha", senhaHashed);
                cmd.ExecuteNonQuery();

                // Commitar a transação
                transaction.Commit();
                MessageBox.Show("Usuário e login inseridos com sucesso!");
            }
            catch (MySqlException ex)
            {
                // Reverter a transação em caso de erro
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Erro ao inserir o usuário: {ex.Message}");
            }
        }

        // Método para atualizar um usuário e seu login
        public void AtualizarUsuario(Usuario usuario, Login login)
        {
            MySqlTransaction transaction = null;
            try
            {
                // Iniciar a transação
                transaction = connection.BeginTransaction();

                // Atualizar dados do usuário
                string queryUsuario = "UPDATE usuario SET nome = @nome, cargo = @cargo, horario = @horario, cpf = @cpf WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(queryUsuario, connection, transaction);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                cmd.Parameters.AddWithValue("@horario", usuario.Horario);
                cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.ExecuteNonQuery();

                // Gerar o hash da nova senha
                string senhaHashed = HashHelper.GerarHashComSalt(login.Senha);

                // Atualizar login e senha
                string queryLogin = "UPDATE login SET login_nome = @login_nome, senha = @senha WHERE usuario_id = @usuario_id";
                cmd = new MySqlCommand(queryLogin, connection, transaction);
                cmd.Parameters.AddWithValue("@login_nome", login.LoginNome);
                cmd.Parameters.AddWithValue("@senha", senhaHashed);
                cmd.Parameters.AddWithValue("@usuario_id", usuario.Id);
                cmd.ExecuteNonQuery();

                // Commitar a transação
                transaction.Commit();
                MessageBox.Show("Usuário e login atualizados com sucesso!");
            }
            catch (MySqlException ex)
            {
                // Reverter a transação em caso de erro
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Erro ao atualizar o usuário: {ex.Message}");
            }
        }

        // Método para deletar um usuário e seu login
        public void DeletarUsuario(int id)
        {
            MySqlTransaction transaction = null;
            try
            {
                // Iniciar a transação
                transaction = connection.BeginTransaction();

                // Deletar login primeiro
                string queryLogin = "DELETE FROM login WHERE usuario_id = @usuario_id";
                MySqlCommand cmd = new MySqlCommand(queryLogin, connection, transaction);
                cmd.Parameters.AddWithValue("@usuario_id", id);
                cmd.ExecuteNonQuery();

                // Deletar o usuário
                string queryUsuario = "DELETE FROM usuario WHERE id = @id";
                cmd = new MySqlCommand(queryUsuario, connection, transaction);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // Commitar a transação
                transaction.Commit();
                MessageBox.Show("Usuário e login deletados com sucesso!");
            }
            catch (MySqlException ex)
            {
                // Reverter a transação em caso de erro
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Erro ao deletar o usuário: {ex.Message}");
            }
        }
    }
}
