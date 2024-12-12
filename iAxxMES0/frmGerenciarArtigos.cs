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
    public partial class frmGerenciarArtigos : Form
    {
        private ControleMaquinas controleMaquinas;
        private ControleArtigo controleArtigo;

        // Nível de permissão do usuário
        private string nivelPermissao;

        public frmGerenciarArtigos(string nivelPermissao)
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            controleArtigo = new ControleArtigo();

            // Carregar artigos no DataGridView
            CarregarArtigos();

            // Configura evento para carregar as máquinas do artigo selecionado
            dgvArtigos.SelectionChanged += dgvArtigos_SelectionChanged;

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

        // Método para carregar fibras no CheckedListBox
        private void CarregarFibras()
        {
            try
            {
                var fibras = controleArtigo.BuscarFibras();
                clbFibras.Items.Clear();

                foreach (var fibra in fibras)
                {
                    clbFibras.Items.Add(new Fibra(fibra.id, fibra.nome), false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fibras: {ex.Message}");
            }
        }

        private void CarregarArtigos()
        {
            var artigos = controleArtigo.ObterTodosArtigos();
            dgvArtigos.DataSource = artigos;
        }

        private void CarregarMaquinasDoArtigo(int artigoId)
        {
            //clbMaquinas.Items.Clear(); // Limpar a lista de máquinas

            //var todasMaquinas = controleArtigo.ObterMaquinasSimplificado(); // Obter apenas Id, Apelido e Artigo
            //var maquinasDoArtigo = controleArtigo.ObterMaquinasDoArtigo(artigoId); // Obter máquinas do artigo

            //foreach (var maquina in todasMaquinas)
            //{
            //    // Adiciona a máquina na lista e marca se ela está no artigo
            //    bool isInArtigo = maquinasDoArtigo.Any(m => m.Id == maquina.Id);
            //    clbMaquinas.Items.Add(maquina.Apelido + " | " + maquina.Artigo, isInArtigo);
            //}
        }

        // Método para limpar os campos após o cadastro
        private void LimparCampos()
        {
            txtArtigo.Clear();
            txtNomeArtigo.Clear();
            txtDescArtigo.Clear();
            numRpmMin.Value = 0;
            numRpmMax.Value = 0;
            foreach (int i in clbFibras.CheckedIndices)
            {
                clbFibras.SetItemChecked(i, false);
            }

            txtArtigo.Focus();
        }

        private void frmGerenciarArtigos_Load(object sender, EventArgs e)
        {
            CarregarFibras();
        }

        private void dgvArtigos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                // Obter o ID do artigo selecionado
                int artigoId = (int)dgvArtigos.SelectedRows[0].Cells["Id"].Value;

                // Preencher os campos de texto com o nome e a descrição do grupo selecionado
                txtArtigo.Text = dgvArtigos.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtDescArtigo.Text = dgvArtigos.SelectedRows[0].Cells["Descricao"].Value?.ToString();

                // Carregar máquinas associadas ao grupo selecionado
                CarregarMaquinasDoArtigo(artigoId);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtArtigo.Text;
            string descricao = txtDescArtigo.Text;
            int rpmMin = (int)numRpmMin.Value;
            int rpmMax = (int)numRpmMax.Value;

            // Lista para armazenar a composição (fibraId e porcentagem)
            var composicao = new List<(int fibraId, decimal porcentagem)>();

            foreach (var item in clbFibras.CheckedItems)
            {
                Fibra fibraItem = (Fibra)item;
                int fibraId = fibraItem.Id;

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Informe a porcentagem para a fibra '{fibraItem.Nome}':",
                    "Porcentagem",
                    "0"
                );

                if (decimal.TryParse(input, out decimal porcentagem) && porcentagem > 0)
                {
                    composicao.Add((fibraId, porcentagem));
                }
                else
                {
                    MessageBox.Show("Porcentagem inválida!");
                    return;
                }
            }

            // Validar se a soma das porcentagens é igual a 100%
            decimal totalPorcentagem = composicao.Sum(c => c.porcentagem);
            if (totalPorcentagem != 100)
            {
                MessageBox.Show("A soma das porcentagens deve ser igual a 100%.");
                return;
            }

            // Chamar o método para cadastrar o artigo com a composição
            try
            {
                controleArtigo.AdicionarArtigo(nome, rpmMin, rpmMax, composicao, descricao);
                MessageBox.Show("Artigo cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar artigo: {ex.Message}");
            }
        }

        private void supervisaoToolStripMenuItem_Click_1(object sender, EventArgs e)
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
