using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace iAxxMES0
{
    public partial class frmDashboard : Form
    {
        private ControleMaquinas controleMaquinas; // Classe para acessar as informações das máquinas
        private List<Maquina> maquinasOriginais; // Lista para armazenar todas as máquinas sem filtro
        private List<MaquinaControl> listaMaquinas; // Lista para armazenar os controles de cada máquina
        private System.Windows.Forms.Timer updateTimer; // Timer para atualizações periódicas

        // Cache para armazenar os dados anteriores
        private List<Maquina> cacheMaquinas = new List<Maquina>();

        // Nível de permissão do usuário
        private string nivelPermissao;

        public frmDashboard(string nivelPermissao)
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            listaMaquinas = new List<MaquinaControl>();

            // Controla a permissão do usuário
            this.nivelPermissao = nivelPermissao;
            AjustarMenuPorPermissao();

            // Atualizar lista de grupos ao abrir o dashboard
            AtualizarListaGrupos();

            // Definir a opção padrão como "Ordenar por Apelido"
            cbxOrdenacao.SelectedIndex = 0;

            // Define a opção padrão do Filtro de Status para "Todos"
            cbxStatusFiltro.SelectedIndex = 0;

            // Define a opção padrão do Filtro de Grupos para "Todos"
            cbxGrupo.SelectedIndex = 0;

            // Configurar os eventos de alteração de seleção para os filtros e ordenação
            cbxOrdenacao.SelectedIndexChanged += AplicarFiltros;
            cbxStatusFiltro.SelectedIndexChanged += AplicarFiltros;
            cbxGrupo.SelectedIndexChanged += AplicarFiltros;
            btnAplicarFiltro.Click += AplicarFiltros;

            // Carregar as máquinas
            CarregarMaquinas();

            // Configurar o Timer para atualizações periódicas
            ConfigurarTimer();
        }

        private void ConfigurarTimer()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000; // Atualiza a cada 1 segundo
            updateTimer.Tick += async (sender, e) => await AtualizarDadosMaquinas();
            updateTimer.Start();
        }

        // Função para atualizar os dados das máquinas
        private async Task AtualizarDadosMaquinas()
        {
            try
            {
                // Tenta obter os dados mais recentes do banco de dados
                List<Maquina> maquinasAtualizadas = await controleMaquinas.ObterDadosAtualizadosAsync();

                // Atualizar o cache com os dados recentes
                cacheMaquinas = maquinasAtualizadas;

                // Atualizar os controles sem recriar os componentes visuais
                foreach (var maquinaAtualizada in maquinasAtualizadas)
                {
                    MaquinaControl maquinaControl = listaMaquinas.FirstOrDefault(m => m.MaquinaId == maquinaAtualizada.Id);
                    if (maquinaControl != null)
                    {
                        maquinaControl.AtualizarDados(
                            maquinaAtualizada.Apelido,
                            maquinaAtualizada.Grupo,
                            maquinaAtualizada.RPM,
                            maquinaAtualizada.Status,
                            maquinaAtualizada.Motivo_Parada,
                            maquinaAtualizada.Diametro,
                            maquinaAtualizada.Finura,
                            maquinaAtualizada.NumeroAlimentadores,
                            maquinaAtualizada.DataHoraStatus
                        );
                    }
                }

                // Atualizar os contadores de status
                AtualizarContadores(maquinasAtualizadas);

                lblStatusBanco.Visible = false; // Esconde o aviso de erro se tudo estiver ok
            }
            catch (Exception ex)
            {
                // Lidar com falhas e exibir os dados do cache
                if (cacheMaquinas.Count > 0)
                {
                    foreach (var maquinaEmCache in cacheMaquinas)
                    {
                        MaquinaControl maquinaControl = listaMaquinas.FirstOrDefault(m => m.MaquinaId == maquinaEmCache.Id);
                        if (maquinaControl != null)
                        {
                            maquinaControl.AtualizarDados(
                                maquinaEmCache.Apelido,
                                maquinaEmCache.Grupo,
                                maquinaEmCache.RPM,
                                maquinaEmCache.Status,
                                maquinaEmCache.Motivo_Parada,
                                maquinaEmCache.Diametro,
                                maquinaEmCache.Finura,
                                maquinaEmCache.NumeroAlimentadores,
                                maquinaEmCache.DataHoraStatus
                            );
                        }
                    }
                }

                lblStatusBanco.Text = "Erro de comunicação com o banco de dados!";
                lblStatusBanco.Visible = true;
            }
        }

        private void AtualizarContadores(List<Maquina> maquinas)
        {
            int numParada = maquinas.Count(m => m.Status == "Parada");
            int numRodando = maquinas.Count(m => m.Status == "Rodando");
            int numCarga = maquinas.Count(m => m.Status == "Carga de fio");
            int numSetup = maquinas.Count(m => m.Status == "Setup");
            int numSemProg = maquinas.Count(m => m.Status == "Sem programação");

            lblNumParada.Text = "Parada(a): " + numParada;
            lblNumRodando.Text = "Rodando: " + numRodando;
            lblNumCarga.Text = "Carga de fio: " + numCarga;
            lblNumSetup.Text = "Setup: " + numSetup;
            lblNumSemProg.Text = "Sem programação: " + numSemProg;
        }

        // Função para carregar as máquinas inicialmente
        private void CarregarMaquinas()
        {
            maquinasOriginais = controleMaquinas.ObterTodasMaquinas();
            ExibirMaquinas(maquinasOriginais);
        }

        // Função para exibir as máquinas no painel
        private void ExibirMaquinas(List<Maquina> maquinas)
        {
            flowLayoutPanelMaquinas.Controls.Clear();
            listaMaquinas.Clear();

            foreach (var maquina in maquinas)
            {
                MaquinaControl maquinaControl = new MaquinaControl
                {
                    MaquinaId = maquina.Id
                };

                maquinaControl.AtualizarDados(
                    maquina.Apelido,
                    maquina.Grupo,
                    maquina.RPM,
                    maquina.Status,
                    maquina.Motivo_Parada,
                    maquina.Diametro,
                    maquina.Finura,
                    maquina.NumeroAlimentadores,
                    maquina.DataHoraStatus
                );

                flowLayoutPanelMaquinas.Controls.Add(maquinaControl);
                listaMaquinas.Add(maquinaControl);
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
                    gerenciarGruposToolStripMenuItem.Visible = true;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = true;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                case "admin":
                    // Todos os itens disponíveis para masters
                    usuáriosToolStripMenuItem.Visible = true;
                    gerenciarGruposToolStripMenuItem.Visible = true;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = true;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                case "operator":
                    // Apenas relatórios acessíveis para operadores
                    usuáriosToolStripMenuItem.Visible = false;
                    gerenciarGruposToolStripMenuItem.Visible = false;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = false;
                    relatórioToolStripMenuItem.Visible = true;
                    break;

                default:
                    // Nenhuma permissão
                    usuáriosToolStripMenuItem.Visible = false;
                    gerenciarGruposToolStripMenuItem.Visible = false;
                    calendárioDeDisponibilidadeToolStripMenuItem.Visible = false;
                    relatórioToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void AtualizarListaGrupos()
        {
            var grupos = controleMaquinas.ObterTodosGrupos();
            cbxGrupo.Items.Clear();
            cbxGrupo.Items.Add("Todos");
            cbxGrupo.Items.AddRange(grupos.Select(g => g.Nome).ToArray());
        }

        // Função para aplicar os filtros
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

            // Filtro de Grupo
            string grupoFiltro = cbxGrupo.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(grupoFiltro) && grupoFiltro != "Todos")
            {
                maquinasFiltradas = maquinasFiltradas
                    .Where(m => m.Grupo.Contains(grupoFiltro))
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

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser cadastro = new frmCadUser(nivelPermissao);
            cadastro.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUser consultar = new frmViewUser();
            consultar.ShowDialog();
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
            // Chamar o Login e fechar o dashboard
            using (frmLogin login = new frmLogin())
            {
                this.Hide();
                login.ShowDialog();
            }

            this.Close();
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
