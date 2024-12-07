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
            var calendarios = controleCalendario.ObterTodosCalendaris();
            dgvCalendarios.DataSource = calendarios;
        }

        private void dgvCalendarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCalendarios.SelectedRows.Count > 0)
            {
                int calendarioId = (int)dgvCalendarios.SelectedRows[0].Cells["Id"].Value;
                CarregarMaquinasDoCalendario(calendarioId);
            }
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
    }
}
