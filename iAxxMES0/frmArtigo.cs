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
    public partial class frmArtigo : Form
    {
        private ControleMaquinas controleMaquinas;
        private ControleArtigo controleArtigo;

        // Nível de permissão do usuário
        private string nivelPermissao;

        public frmArtigo(string nivelPermissao)
        {
            InitializeComponent();

            // Controla a permissão do usuário
            this.nivelPermissao = nivelPermissao;
            AjustarMenuPorPermissao();
        }

        // Método para ajudar o Menu conforme o nível de privilégio
        private void AjustarMenuPorPermissao()
        {
            switch (nivelPermissao)
            {
                case "master":
                    // Todos os itens disponíveis para masters
                    usuáriosToolStripMenuItem.Visible = true;
                    supervisaoToolStripMenuItem.Visible = true;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = true;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                case "admin":
                    // Todos os itens disponíveis para masters
                    usuáriosToolStripMenuItem.Visible = true;
                    supervisaoToolStripMenuItem.Visible = true;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = true;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                case "operator":
                    // Apenas relatórios acessíveis para operadores
                    usuáriosToolStripMenuItem.Visible = false;
                    supervisaoToolStripMenuItem.Visible = false;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = false;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                default:
                    // Nenhuma permissão
                    usuáriosToolStripMenuItem.Visible = false;
                    supervisaoToolStripMenuItem.Visible = false;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = false;
                    relatórioToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void supervisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o Dashboard e fechar a tela de grupos
            using (frmDashboard dashboard = new frmDashboard(nivelPermissao))
            {
                this.Hide();
                dashboard.ShowDialog();
            }

            this.Close();
        }

        private void gerenciarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o Gerenciar Grupos e fechar o Dashboard
            using (frmGerenciarGrupos gerenciarGrupos = new frmGerenciarGrupos(controleMaquinas, nivelPermissao))
            {
                this.Hide();
                gerenciarGrupos.ShowDialog();
            }

            this.Close();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUser consultar = new frmViewUser();
            consultar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser cadastro = new frmCadUser(nivelPermissao);
            cadastro.ShowDialog();
        }

        private void visualizarCalendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendario calendario = new frmCalendario();
            calendario.ShowDialog();
        }

        private void gerenciarCalendáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarCalendarios gerenciarCalendarios = new frmGerenciarCalendarios();
            gerenciarCalendarios.ShowDialog();
        }

        private void cadastroDeIndisponibilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCalendario cadCalendario = new frmCadCalendario();
            cadCalendario.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o Login e fechar a tela de grupos
            using (frmLogin login = new frmLogin())
            {
                this.Hide();
                login.ShowDialog();
            }

            this.Close();
        }
    }
}
