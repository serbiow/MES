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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Login TelaLogin = new Login();
            TelaLogin.ShowDialog();

            //chama a conexão com o banco no início do código
            //cl_conexao c = new cl_conexao();
            //MessageBox.Show(c.conectar());
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUser cadastro = new CadUser();
            cadastro.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
