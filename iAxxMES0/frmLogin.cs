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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Capturando o texto dos TextBoxes
            string loginNome = txtLogin.Text;
            string senha = txtSenha.Text;

            // Chamando o método de validação de login da classe ControleUsuario
            if (controleUsuario.ValidarLogin(loginNome, senha))
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
        }
    }
}
