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
    public partial class frmDashboard : Form
    {
        private ControleMaquinas controleMaquinas; // Classe para acessar as informações das máquinas
        private List<Maquina> maquinasOriginais; // Lista para armazenar todas as máquinas sem filtro
        private List<MaquinaControl> listaMaquinas; // Lista para armazenar os controles de cada máquina
        private System.Windows.Forms.Timer updateTimer; // Especificando o namespace completo por conta de ambiguidade

        public frmDashboard()
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            listaMaquinas = new List<MaquinaControl>();

            // Definir a opção padrão como "Ordenar por Apelido"
            cbxOrdenacao.SelectedIndex = 0;

            // Define a opção padrão para "Todos"
            cbxStatusFiltro.SelectedIndex = 0;

            // Configurar os eventos de alteração de seleção para os filtros e ordenação
            cbxOrdenacao.SelectedIndexChanged += AplicarFiltros;
            cbxStatusFiltro.SelectedIndexChanged += AplicarFiltros;
            //txtRpmMin.TextChanged += AplicarFiltros;
            //txtRpmMax.TextChanged += AplicarFiltros;
            btnAplicarFiltro.Click += AplicarFiltros;

            // Carregar as máquinas
            CarregarMaquinas();

            // Configurar o Timer para atualizações periódicas
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 30000; // Atualizar a cada 30 segundos
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Atualizar os dados das máquinas e reaplicar os filtros
            AtualizarDadosMaquinas();
        }

        private async void AtualizarDadosMaquinas()
        {
            // Obter os dados mais recentes do banco de dados
            List<Maquina> maquinasAtualizadas = await controleMaquinas.ObterDadosAtualizadosAsync();

            // Atualizar a lista original com os dados mais recentes
            maquinasOriginais = maquinasAtualizadas;

            // Reaplicar os filtros após a atualização para garantir que os dados mais recentes sejam considerados
            AplicarFiltros(null, null);
        }

        private void AbrirDetalhesMaquina(int maquinaId)
        {
            // Abrir um novo formulário com os detalhes da máquina selecionada
            //DetalhesMaquinaForm detalhesForm = new DetalhesMaquinaForm(maquinaId);
            //detalhesForm.Show();
        }

        private void CarregarMaquinas()
        {
            // Obter todas as máquinas
            maquinasOriginais = controleMaquinas.ObterTodasMaquinas();

            // Exibir as máquinas no dashboard
            ExibirMaquinas(maquinasOriginais);
        }

        // Método para exibir as máquinas no painel
        private void ExibirMaquinas(List<Maquina> maquinas)
        {
            // Limpar o painel de layout
            flowLayoutPanelMaquinas.Controls.Clear();
            listaMaquinas.Clear();

            foreach (var maquina in maquinas)
            {
                MaquinaControl maquinaControl = new MaquinaControl
                {
                    MaquinaId = maquina.Id
                };

                // Atualizar o controle com as informações da máquina
                maquinaControl.AtualizarDados(maquina.Apelido, maquina.RPM, maquina.Status);

                // Adicionar ao painel de layout
                flowLayoutPanelMaquinas.Controls.Add(maquinaControl);

                // Adicionar à lista de máquinas
                listaMaquinas.Add(maquinaControl);
            }
        }

        // Método para aplicar os filtros
        private void AplicarFiltros(object sender, EventArgs e)
        {
            // Usar sempre os dados mais recentes em 'maquinasOriginais'
            List<Maquina> maquinasFiltradas = maquinasOriginais;

            // Filtro de status
            string statusFiltro = cbxStatusFiltro.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(statusFiltro) && statusFiltro != "Todos")
            {
                maquinasFiltradas = maquinasFiltradas
                    .Where(m => m.Status.Equals(statusFiltro, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filtro de RPM mínimo
            if (int.TryParse(txtRpmMin.Text, out int rpmMin))
            {
                maquinasFiltradas = maquinasFiltradas
                    .Where(m => m.RPM >= rpmMin)
                    .ToList();
            }

            // Filtro de RPM máximo
            if (int.TryParse(txtRpmMax.Text, out int rpmMax))
            {
                maquinasFiltradas = maquinasFiltradas
                    .Where(m => m.RPM <= rpmMax)
                    .ToList();
            }

            // Filtro de Apelido
            string apelidoFiltro = txtFiltroApelido.Text;
            if (!string.IsNullOrEmpty(apelidoFiltro))
            {
                // Usando Contains para permitir a busca parcial e ignorando diferenças de maiúsculas/minúsculas
                maquinasFiltradas = maquinasFiltradas
                    .Where(m => m.Apelido.IndexOf(apelidoFiltro, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            // Aplica a ordenação conforme a escolha do ComboBox de ordenação
            string ordenacao = cbxOrdenacao.SelectedItem.ToString();
            switch (ordenacao)
            {
                case "Maquina":
                    maquinasFiltradas = maquinasFiltradas.OrderBy(m => m.Apelido).ToList();
                    break;

                case "Status":
                    maquinasFiltradas = maquinasFiltradas.OrderBy(m => m.Status).ToList();
                    break;
            }

            // Exibir as máquinas filtradas e ordenadas
            ExibirMaquinas(maquinasFiltradas);
        }

        private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoRefresh.Checked)
            {
                // Ativa o refresh automático
                updateTimer.Start();
            }
            else
            {
                // Desativa o refresh automático
                updateTimer.Stop();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Atualizar os dados das máquinas manualmente
            AtualizarDadosMaquinas();
        }

        private void frmDashboard_Load_1(object sender, EventArgs e)
        {
            // Chama o formulário de Login no início
            frmLogin TelaLogin = new frmLogin();
            TelaLogin.ShowDialog();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser cadastro = new frmCadUser();
            cadastro.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Keypress do txtFiltro (Enter)
        private void txtFiltroApelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                // Chama o método AplicarFiltros
                AplicarFiltros(null, null);
            }
        }

        // Keypress do txtRpmMin (Enter)
        private void txtRpmMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                // Chama o método AplicarFiltros
                AplicarFiltros(null, null);
            }
        }

        // Keypress do txtRpmMax (Enter)
        private void txtRpmMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                // Chama o método AplicarFiltros
                AplicarFiltros(null, null);
            }
        }
    }
}
