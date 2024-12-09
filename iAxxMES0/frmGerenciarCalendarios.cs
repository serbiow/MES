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
    public partial class frmGerenciarCalendarios : Form
    {
        private ControleCalendario controleCalendario;
        private ControleMaquinas controleMaquinas;
        public frmGerenciarCalendarios()
        {
            InitializeComponent();
            controleCalendario = new ControleCalendario();
            controleMaquinas = new ControleMaquinas();

            // Carregar os calendários no DataGridView
            CarregarCalendarios();

            // Configura evento para carregar as máquinas do calendários selecionado
        }

        private void CarregarCalendarios()
        {
            var calendarios = controleCalendario.ObterTodosCalendarios();
            dgvCalendarios.DataSource = calendarios;
        }

        private void CarregarMaquinasDoCalendario(int calendarioId)
        {
            clbMaquinas.Items.Clear(); // Limpar a lista de máquinas

            var todasMaquinas = controleMaquinas.ObterMaquinasSimplificado(); // Obter apenas Id e Apelido
            var maquinasDoCalendario = controleCalendario.ObterMaquinasDoCalendario(calendarioId); // Obter máquinas do calendário

            foreach (var maquina in todasMaquinas)
            {
                // Adiciona a máquina na lista e marca se ela está no calendário
                bool isInCalendar = maquinasDoCalendario.Any(m => m.Id == maquina.Id);
                clbMaquinas.Items.Add(maquina.Apelido, isInCalendar);
            }
        }

        private void dgvCalendarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCalendarios.SelectedRows.Count > 0)
            {
                // Obter o ID do calendário selecionado
                int calendarioId = (int)dgvCalendarios.SelectedRows[0].Cells["Id"].Value;

                // Preencher os campos de texto com o nome e a descrição do calendário selecionado
                txtCalendario.Text = dgvCalendarios.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtDescCalendario.Text = dgvCalendarios.SelectedRows[0].Cells["Descricao"].Value?.ToString();

                // Carregar máquinas associadas ao calendário selecionado
                CarregarMaquinasDoCalendario(calendarioId);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeCalendario = txtCalendario.Text;
            string descCalendario = txtDescCalendario.Text;
            if (!string.IsNullOrEmpty(nomeCalendario) && !string.IsNullOrEmpty(descCalendario))
            {
                controleCalendario.AdicionarCalendario(nomeCalendario, descCalendario);
                CarregarCalendarios(); // Atualizar lista
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCalendarios.SelectedRows.Count > 0)
            {
                int calendarioId = (int)dgvCalendarios.SelectedRows[0].Cells["Id"].Value;
                string novoNome = txtCalendario.Text;
                string novaDesc = txtDescCalendario.Text;
                if (!string.IsNullOrEmpty(novoNome) && !string.IsNullOrEmpty(novaDesc))
                {
                    controleCalendario.EditarCalendario(calendarioId, novoNome, novaDesc);
                    CarregarCalendarios(); // Atualizar lista
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCalendario.Clear();
            txtNomeCalendario.Clear();
            txtDescCalendario.Clear();
            dgvCalendarios.DataSource = null;
            clbMaquinas.Items.Clear();

            txtNomeCalendario.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCalendarios.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir este calendário?", "Deletar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int calendarioId = (int)dgvCalendarios.SelectedRows[0].Cells["Id"].Value;
                    controleCalendario.ExcluirCalendario(calendarioId);
                    CarregarCalendarios(); // Atualizar lista
                }
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            var calendarios = controleCalendario.ObterTodosCalendarios();
            dgvCalendarios.DataSource = calendarios;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dgvCalendarios.SelectedRows.Count > 0)
            {
                int calendarioId = (int)dgvCalendarios.SelectedRows[0].Cells["Id"].Value;

                // Limpar associações antigas
                controleCalendario.RemoverTodasMaquinasDoCalendario(calendarioId);

                // Adicionar associações selecionadas
                for (int i = 0; i < clbMaquinas.Items.Count; i++)
                {
                    if (clbMaquinas.GetItemChecked(i))
                    {
                        var maquina = controleMaquinas.ObterMaquinaPorApelido(clbMaquinas.Items[i].ToString());
                        controleCalendario.AssociarMaquinaAoCalendario(calendarioId, maquina.Id);
                    }
                }

                MessageBox.Show("Máquinas atualizadas para o calendário selecionado.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCalendario.Text))
            {
                MessageBox.Show("Por favor, digite um valor para buscar.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeCalendario = txtNomeCalendario.Text.Trim();
            
            List<Calendario> calendariosEncontrados = controleCalendario.ObterCalendariosPorNome(nomeCalendario);

            dgvCalendarios.DataSource = calendariosEncontrados;
        }
    }
}
