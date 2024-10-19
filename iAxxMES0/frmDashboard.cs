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

        public frmDashboard()
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            listaMaquinas = new List<MaquinaControl>();

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
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000; // Atualizar a cada 1 segundo
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Atualizar os dados das máquinas e reaplicar os filtros
            AtualizarDadosMaquinas();
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
                        maquinaControl.AtualizarDados(maquinaAtualizada.Apelido,
                                                      maquinaAtualizada.Grupo,
                                                      maquinaAtualizada.RPM,
                                                      maquinaAtualizada.Status,
                                                      maquinaAtualizada.Motivo_Parada,
                                                      maquinaAtualizada.Diametro,
                                                      maquinaAtualizada.Finura,
                                                      maquinaAtualizada.NumeroAlimentadores,
                                                      maquinaAtualizada.DataHoraStatus);
                    }
                }

                lblStatusBanco.Visible = false; // Esconde o aviso de erro se tudo estiver ok
            }
            catch (Exception ex)
            {
                // Se houver falha, continuar exibindo dados em cache
                if (cacheMaquinas.Count > 0)
                {
                    foreach (var maquinaEmCache in cacheMaquinas)
                    {
                        MaquinaControl maquinaControl = listaMaquinas.FirstOrDefault(m => m.MaquinaId == maquinaEmCache.Id);
                        if (maquinaControl != null)
                        {
                            maquinaControl.AtualizarDados(maquinaEmCache.Apelido,
                                                          maquinaEmCache.Grupo,
                                                          maquinaEmCache.RPM,
                                                          maquinaEmCache.Status,
                                                          maquinaEmCache.Motivo_Parada,
                                                          maquinaEmCache.Diametro,
                                                          maquinaEmCache.Finura,
                                                          maquinaEmCache.NumeroAlimentadores,
                                                          maquinaEmCache.DataHoraStatus);
                        }
                    }
                }

                // Exibe a mensagem de erro na interface
                lblStatusBanco.Text = "Erro de comunicação com o banco de dados!";
                lblStatusBanco.Visible = true;

                // Log do erro
                LogError("Erro ao atualizar dados das máquinas: " + ex.Message);

                // Iniciar tentativa de reconexão em segundo plano
                await TentarReconectar();
            }
        }

        // Função para tentar reconectar ao banco de dados
        private async Task TentarReconectar()
        {
            // Tentar reconectar a cada 10 segundos até obter sucesso
            while (true)
            {
                try
                {
                    lblStatusBanco.Text = "Tentando reconectar ao banco de dados...";
                    await Task.Delay(10000);  // Espera de 10 segundos

                    // Testa se o banco está disponível
                    controleMaquinas.TestarConexao();

                    // Se reconectar com sucesso
                    lblStatusBanco.Text = "Reconectado ao banco de dados.";
                    lblStatusBanco.ForeColor = Color.Green;
                    lblStatusBanco.Visible = true;

                    // Atualiza os dados novamente após reconectar
                    await AtualizarDadosMaquinas();
                    break; // Sai do loop quando a conexão for restabelecida
                }
                catch
                {
                    // Continua tentando a reconexão
                    lblStatusBanco.Text = "Ainda tentando reconectar...";
                }
            }
        }

        // Função para gravar o erro no log
        private void LogError(string errorMessage)
        {
            string logFilePath = "error_log.txt";  // Caminho do arquivo de log
            string logEntry = $"{DateTime.Now}: {errorMessage}\n";  // Entrada de log com a data e a mensagem de erro

            // Escreve no arquivo de log
            try
            {
                System.IO.File.AppendAllText(logFilePath, logEntry);
            }
            catch (Exception logEx)
            {
                // Em caso de falha no log, talvez notificar o usuário ou registrar em outro lugar
                Console.WriteLine($"Falha ao registrar o log: {logEx.Message}");
            }
        }

        // Função para carregar as máquinas inicialmente
        private void CarregarMaquinas()
        {
            // Obter todas as máquinas
            maquinasOriginais = controleMaquinas.ObterTodasMaquinas();

            // Exibir as máquinas no dashboard
            ExibirMaquinas(maquinasOriginais);
        }

        // Função para exibir as máquinas no painel
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
                maquinaControl.AtualizarDados(maquina.Apelido, maquina.Grupo, maquina.RPM, maquina.Status, maquina.Motivo_Parada,
                                              maquina.Diametro, maquina.Finura, maquina.NumeroAlimentadores, maquina.DataHoraStatus);

                // Adicionar ao painel de layout
                flowLayoutPanelMaquinas.Controls.Add(maquinaControl);

                // Adicionar à lista de máquinas
                listaMaquinas.Add(maquinaControl);
            }
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
                    .Where(m => m.Grupo.Equals(grupoFiltro, StringComparison.OrdinalIgnoreCase))
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
