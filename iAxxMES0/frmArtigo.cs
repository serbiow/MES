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

            controleArtigo = new ControleArtigo();
            controleMaquinas = new ControleMaquinas();

            // Controla a permissão do usuário
            this.nivelPermissao = nivelPermissao;
            AjustarMenuPorPermissao();

            // Atribui o a data atual nos campos de data
            dtpDataInicial.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
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

        private void RecarregarMaquinas()
        {
            clbMaquinas.Items.Clear(); // Limpar a lista de máquinas

            var todasMaquinas = controleMaquinas.ObterMaquinasSimplificado(); // Obter apenas Id e Apelido

            foreach (var maquina in todasMaquinas)
            {
                // Adiciona a máquina na lista
                clbMaquinas.Items.Add(maquina.Apelido);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                int artigoId = (int)dgvArtigos.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    // Verificar se a máquina tem algum calendário

                    // Verificar se o período de tempo possui indisponibilidade

                    // Verificar se a máquina já vai rodar outro artigo dentro do período

                    // Fazer tratativas adequadas

                    // Associar o artigo na máquina
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao associar artigo na(s) máquina(s): {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um artigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeArtigo.Text))
            {
                MessageBox.Show("Por favor, digite um valor para buscar.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeArtigo = txtNomeArtigo.Text.Trim();

            List<Artigo> artigosEncontrados = controleArtigo.ObterArtigosPorNome(nomeArtigo);

            dgvArtigos.DataSource = artigosEncontrados;
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            var artigos = controleArtigo.ObterTodosArtigos();
            dgvArtigos.DataSource = artigos;
        }

        private void dgvArtigos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                // Recarregar lista de máquinas
                RecarregarMaquinas();
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
            using (frmGerenciarGrupos gerenciarGrupos = new frmGerenciarGrupos(nivelPermissao))
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
