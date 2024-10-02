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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtNome.Clear();
            cbxNivelPermissao.SelectedIndex = -1;
            mtxtMatricula.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();

            txtNome.Focus();
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
    }
}
