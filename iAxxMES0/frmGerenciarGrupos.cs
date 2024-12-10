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
    public partial class frmGerenciarGrupos : Form
    {
        private ControleMaquinas controleMaquinas;

        // Nível de permissão do usuário
        private string nivelPermissao;

        public frmGerenciarGrupos(ControleMaquinas controle, string nivelPermissao)
        {
            InitializeComponent();
            controleMaquinas = controle;

            // Carregar os grupos no DataGridView
            CarregarGrupos();

            // Configura evento para carregar as máquinas do grupo selecionado
            dgvGrupos.SelectionChanged += DgvGrupos_SelectionChanged;

            // Controla a permissão do usuário
            this.nivelPermissao = nivelPermissao;
            AjustarMenuPorPermissao();
        }

        private void CarregarGrupos()
        {
            var grupos = controleMaquinas.ObterTodosGrupos();
            dgvGrupos.DataSource = grupos;
        }

        private void DgvGrupos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                // Obter o ID do grupo selecionado
                int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;

                // Preencher os campos de texto com o nome e a descrição do grupo selecionado
                txtGrupo.Text = dgvGrupos.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtDescGrupo.Text = dgvGrupos.SelectedRows[0].Cells["Descricao"].Value?.ToString();

                // Carregar máquinas associadas ao grupo selecionado
                CarregarMaquinasDoGrupo(grupoId);
            }
        }

        private void CarregarMaquinasDoGrupo(int grupoId)
        {
            clbMaquinas.Items.Clear(); // Limpar a lista de máquinas

            var todasMaquinas = controleMaquinas.ObterMaquinasSimplificado(); // Obter apenas Id e Apelido
            var maquinasDoGrupo = controleMaquinas.ObterMaquinasDoGrupo(grupoId); // Obter máquinas do grupo

            foreach (var maquina in todasMaquinas)
            {
                // Adiciona a máquina na lista e marca se ela está no grupo
                bool isInGroup = maquinasDoGrupo.Any(m => m.Id == maquina.Id);
                clbMaquinas.Items.Add(maquina.Apelido, isInGroup);
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;

                // Limpar associações antigas
                controleMaquinas.RemoverTodasMaquinasDoGrupo(grupoId);

                // Adicionar associações selecionadas
                for (int i = 0; i < clbMaquinas.Items.Count; i++)
                {
                    if (clbMaquinas.GetItemChecked(i))
                    {
                        var maquina = controleMaquinas.ObterMaquinaPorApelido(clbMaquinas.Items[i].ToString());
                        controleMaquinas.AssociarMaquinaAoGrupo(grupoId, maquina.Id);
                    }
                }

                MessageBox.Show("Máquinas atualizadas para o grupo selecionado.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um grupo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeGrupo = txtGrupo.Text;
            string descGrupo = txtDescGrupo.Text;
            if (!string.IsNullOrEmpty(nomeGrupo) && !string.IsNullOrEmpty(descGrupo))
            {
                controleMaquinas.AdicionarGrupo(nomeGrupo, descGrupo);
                CarregarGrupos(); // Atualizar lista
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;
                string novoNome = txtGrupo.Text;
                string novaDesc = txtDescGrupo.Text;
                if (!string.IsNullOrEmpty(novoNome) && !string.IsNullOrEmpty(novaDesc))
                {
                    controleMaquinas.EditarGrupo(grupoId, novoNome, novaDesc);
                    CarregarGrupos(); // Atualizar lista
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir este grupo?", "Deletar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;
                    controleMaquinas.ExcluirGrupo(grupoId);
                    CarregarGrupos(); // Atualizar lista
                }
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            var grupos = controleMaquinas.ObterTodosGrupos();
            dgvGrupos.DataSource = grupos;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGrupo.Clear();
            txtNomeGrupo.Clear();
            txtDescGrupo.Clear();
            dgvGrupos.DataSource = null;
            clbMaquinas.Items.Clear();

            txtNomeGrupo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeGrupo.Text))
            {
                MessageBox.Show("Por favor, digite um valor para buscar.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeGrupo = txtNomeGrupo.Text.Trim();
            List<Grupo> gruposEncontrados = controleMaquinas.ObterGruposPorNome(nomeGrupo);

            dgvGrupos.DataSource = gruposEncontrados;
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
