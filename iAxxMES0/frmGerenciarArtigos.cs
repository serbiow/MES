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

        public frmGerenciarArtigos()
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            controleArtigo = new ControleArtigo();

            // Carregar artigos no DataGridView
            CarregarArtigos();

            // Configura evento para carregar as máquinas do artigo selecionado
            dgvArtigos.SelectionChanged += dgvArtigos_SelectionChanged;
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
                    clbFibras.Items.Add(fibra, false); // Adiciona o objeto Fibra diretamente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fibras: {ex.Message}");
            }
        }

        private void CarregarFibrasDoArtigo(int artigoId)
        {
            clbFibras.Items.Clear();

            var todasFibras = controleArtigo.BuscarFibras();
            var fibrasDoArtigo = controleArtigo.ObterFibrasDoArtigo(artigoId);

            foreach (var fibra in todasFibras)
            {
                bool isInArtigo = fibrasDoArtigo.Any(f => f.Id == fibra.Id);
                clbFibras.Items.Add(fibra, isInArtigo); // Adiciona o objeto Fibra diretamente
            }
      
        }

        private void CarregarArtigos()
        {
            var artigos = controleArtigo.ObterTodosArtigos();
            dgvArtigos.DataSource = artigos;
        }

        // Método para limpar os campos após o cadastro
        private void LimparCampos()
        {
            txtArtigo.Clear();
            txtNomeArtigo.Clear();
            txtDescArtigo.Clear();
            numRpmMin.Value = 0;
            txtRpmMedio.Clear();
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
                numRpmMin.Value = (int)dgvArtigos.SelectedRows[0].Cells["Rpm_Min"].Value;
                txtRpmMedio.Text = dgvArtigos.SelectedRows[0].Cells["Rpm_Media"].Value.ToString();
                numRpmMax.Value = (int)dgvArtigos.SelectedRows[0].Cells["Rpm_Max"].Value;

                // Carrega as fibras daquele artigo
                CarregarFibrasDoArtigo(artigoId);
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
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
                CarregarArtigos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar artigo: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                int artigoId = (int)dgvArtigos.SelectedRows[0].Cells["Id"].Value;
                string novoNome = txtArtigo.Text;
                string novaDesc = txtDescArtigo.Text;
                int novoRpmMin = (int)numRpmMin.Value;
                int novoRpmMax = (int)numRpmMax.Value;

                // Validação dos campos de entrada
                if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novaDesc))
                {
                    MessageBox.Show("Nome e descrição não podem estar vazios.");
                    return;
                }

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

                try
                {
                    // Chamar o método para editar o artigo e a composição associada
                    controleArtigo.EditarArtigo(artigoId, novoNome, novoRpmMin, novoRpmMax, novaDesc, composicao);

                    MessageBox.Show("Artigo editado com sucesso!");
                    LimparCampos();    // Limpar os campos após a edição
                    CarregarArtigos(); // Atualizar a lista de artigos no DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar artigo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um artigo para editar.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvArtigos.SelectedRows.Count > 0)
            {
                // Obter o ID do artigo selecionado
                int artigoId = (int)dgvArtigos.SelectedRows[0].Cells["Id"].Value;
                string artigoNome = dgvArtigos.SelectedRows[0].Cells["Nome"].Value.ToString();

                // Confirmar exclusão com o usuário
                var confirmResult = MessageBox.Show(
                    $"Tem certeza que deseja excluir o artigo '{artigoNome}' (ID: {artigoId})?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Chamar o método de exclusão da ControleArtigo
                        controleArtigo.ExcluirArtigo(artigoId);

                        MessageBox.Show($"Artigo '{artigoNome}' excluído com sucesso!");

                        // Atualizar o DataGridView após a exclusão
                        CarregarArtigos();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir artigo: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um artigo para excluir.");
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
    }
}
