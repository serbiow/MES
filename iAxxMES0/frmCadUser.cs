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
            if (cbxCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cargo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(mtxtCPF.Text) || mtxtCPF.Text.Length < 11)
            {
                MessageBox.Show("O campo CPF não pode estar vazio e deve conter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um turno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int cargo = cbxCargo.SelectedIndex; // Índices: 0 para master, 1 para admin, 2 para operator
            string cpf = mtxtCPF.Text;
            int horario = cbxTurno.SelectedIndex; // Índices: 0 para manhã, 1 para tarde, 2 para noite
            string login_nome = txtLogin.Text;
            string senha = txtSenha.Text;

            // Criando os objetos Usuario e Login para inserção
            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Cargo = ConvertCargoIndexToString(cargo),
                CPF = cpf,
                Horario = ConvertTurnoIndexToString(horario)
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
            cbxCargo.SelectedIndex = -1;
            mtxtCPF.Clear();
            cbxTurno.SelectedIndex = -1;
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();

            txtNome.Focus();
        }

        // Método auxiliar para converter o índice do cargo em string
        private string ConvertCargoIndexToString(int cargoIndex)
        {
            switch (cargoIndex)
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

        // Método auxiliar para converter o índice do turno em string
        private string ConvertTurnoIndexToString(int turnoIndex)
        {
            switch (turnoIndex)
            {
                case 0:
                    return "manha";
                case 1:
                    return "tarde";
                case 2:
                    return "noite";
                default:
                    return "manha"; // Valor padrão
            }
        }
    }
}
