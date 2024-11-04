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

        public frmGerenciarGrupos(ControleMaquinas controle)
        {
            InitializeComponent();
            controleMaquinas = controle;

            // Carregar os grupos no DataGridView
            CarregarGrupos();

            // Configura evento para carregar as máquinas do grupo selecionado
            dgvGrupos.SelectionChanged += DgvGrupos_SelectionChanged;
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
                int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;
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

                MessageBox.Show("Máquinas atualizadas para o grupo selecionado.");
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
                int grupoId = (int)dgvGrupos.SelectedRows[0].Cells["Id"].Value;
                controleMaquinas.ExcluirGrupo(grupoId);
                CarregarGrupos(); // Atualizar lista
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
            txtDescGrupo.Clear();
            dgvGrupos.DataSource = null;

            txtGrupo.Focus();
        }
    }
}
