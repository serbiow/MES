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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Digite Login e senha para acessar o sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Função detalhada para a conexão com o banco
                    //bool logar = lgn.Logar(txtLogin.Text, txtSenha.Text);

                    //if (logar == true)
                    //{
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Login e/ou senha inválidos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtLogin.Clear();
                    //    txtSenha.Clear();
                    //    txtLogin.Focus();
                    //}

                    // Exemplo simples sem bando de dados
                    if (txtLogin.Text == "a" && txtSenha.Text == "a")
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
