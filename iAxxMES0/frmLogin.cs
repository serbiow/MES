using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iAxxMES0
{
    public partial class frmLogin : Form
    {

        private ControleUsuario controleUsuario;

        public frmLogin()
        {
            InitializeComponent();
            controleUsuario = new ControleUsuario(); // Instanciando a classe de controle
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            // Capturando o texto dos TextBoxes
            string loginNome = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            // Verificação de campos vazios
            if (string.IsNullOrEmpty(loginNome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Chamando o método de validação de login da classe ControleUsuario
                if (controleUsuario.ValidarLogin(loginNome, senha))
                {
                    var usuario = controleUsuario.BuscarUsuarioPorLogin(loginNome);
                    if (usuario != null)
                    {
                        MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Passando os privilégios para o Dashboard
                        using (frmDashboard dashboard = new frmDashboard(usuario.Nivel_Permissao))
                        {
                            this.Hide();
                            dashboard.ShowDialog();
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar informações do usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o login. Tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Executa o método de login
                btnEntrar_Click_1(sender, e);

                // Evita que o som de "beep" seja emitido ao pressionar Enter
                e.Handled = true;
            }
        }
    }
}
