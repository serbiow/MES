using Google.Protobuf.WellKnownTypes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iAxxMES0
{
    public partial class frmCadUser : Form
    {
        public frmCadUser()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validações dos campos de texto e comboboxes
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxNivelPermissao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a permissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(mtxtMatricula.Text) || mtxtMatricula.Text.Length < 10)
            {
                MessageBox.Show("O campo Matricula não pode estar vazio e deve conter 10 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("O campo Login não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Capturando as informações dos TextBoxes e ComboBoxes
            string nome = txtNome.Text;
            int nivel_permissao = cbxNivelPermissao.SelectedIndex; // Índices: 0 para master, 1 para admin, 2 para operator
            string registro_matricula = mtxtMatricula.Text;
            string login_nome = txtLogin.Text;
            string senha = txtSenha.Text;

            // Criando os objetos Usuario e Login para inserção
            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Nivel_Permissao = ConvertNivelPermissaoIndexToString(nivel_permissao),
                Registro_Matricula = registro_matricula
            };

            Login novoLogin = new Login
            {
                LoginNome = login_nome,
                Senha = senha
            };

            // Inserindo o usuário e login no banco de dados usando ControleUsuario
            ControleUsuario controle = new ControleUsuario();
            controle.InserirUsuario(novoUsuario, novoLogin);

            // Limpar formulário e focar no primeiro txt
            LimparCampos();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Validações dos campos de texto e comboboxes
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxNivelPermissao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a permissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(mtxtMatricula.Text) || mtxtMatricula.Text.Length < 10)
            {
                MessageBox.Show("O campo Matricula não pode estar vazio e deve conter 10 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("O campo Login não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Capturando as informações dos TextBoxes e ComboBoxes
            int userId = Int32.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            int nivel_permissao = cbxNivelPermissao.SelectedIndex; // Índices: 0 para master, 1 para admin, 2 para operator
            string registro_matricula = mtxtMatricula.Text;
            string login_nome = txtLogin.Text;
            string senha = txtSenha.Text;

            // Criando os objetos Usuario e Login para inserção
            Usuario novoUsuario = new Usuario
            {
                Id = userId,
                Nome = nome,
                Nivel_Permissao = ConvertNivelPermissaoIndexToString(nivel_permissao),
                Registro_Matricula = registro_matricula
            };

            Login novoLogin = new Login
            {
                LoginNome = login_nome,
                Senha = senha
            };

            // Alterando o usuário e login no banco de dados usando ControleUsuario
            ControleUsuario controle = new ControleUsuario();
            controle.AtualizarUsuario(novoUsuario, novoLogin);
        }

        // Método auxiliar para converter o índice do nível de permissão em string
        private string ConvertNivelPermissaoIndexToString(int NivelPermissaoIndex)
        {
            switch (NivelPermissaoIndex)
            {
                case 0:
                    return "master";
                case 1:
                    return "admin";
                case 2:
                    return "operator";
                default:
                    return "operator"; // Valor padrão
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Verificar se o campo de código está vazio
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, insira um código de usuário.");
                return; // Interrompe o processamento se o código estiver vazio
            }

            // Atribuir código na variável
            int usuarioId;
            if (!Int32.TryParse(txtCodigo.Text, out usuarioId))
            {
                MessageBox.Show("Por favor, insira um código numérico válido.");
                return; // Interrompe o processamento se o código não for numérico
            }

            // Buscar usuário
            ControleUsuario controle = new ControleUsuario();
            Usuario user = controle.BuscarUsuario(usuarioId);

            // Limpar Campos
            LimparCampos();

            if (user != null)
            {
                // Preencher os campos com as informações do usuário buscado
                txtNome.Text = user.Nome;
                mtxtMatricula.Text = user.Registro_Matricula;
                txtLogin.Text = user.Login_Nome;

                switch (user.Nivel_Permissao)
                {
                    case "master":
                        cbxNivelPermissao.SelectedIndex = 0;
                        break;
                    case "admin":
                        cbxNivelPermissao.SelectedIndex = 1;
                        break;
                    case "operator":
                        cbxNivelPermissao.SelectedIndex = 2;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuário não existe");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de código está vazio
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, insira um código de usuário.");
                return; // Interrompe o processamento se o código estiver vazio
            }

            // Atribuir código na variável
            int userId;
            if (!Int32.TryParse(txtCodigo.Text, out userId))
            {
                MessageBox.Show("Por favor, insira um código numérico válido.");
                return; // Interrompe o processamento se o código não for numérico
            }

            DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir este usuário?", "Deletar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Deletar usuário
                ControleUsuario controle = new ControleUsuario();
                controle.DeletarUsuario(userId);
                LimparCampos();
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cbxNivelPermissao.SelectedIndex = -1;
            mtxtMatricula.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada do caractere
            }
        }

        
    }
}
