using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace iAxxMES0
{
    public partial class frmMaquina : Form
    {
        private int maquinaId; // Para armazenar o ID da máquina que está sendo exibida
        private ControleMaquinas controleMaquinas; // Para obter os dados da máquina
        private System.Windows.Forms.Timer timer; // Timer para atualizar o gráfico periodicamente

        public frmMaquina(string apelido, int finura, decimal diametro, int numeroAlimentadores, string grupo, int maquinaId)
        {
            InitializeComponent();

            this.maquinaId = maquinaId;
            controleMaquinas = new ControleMaquinas(); // Inicializa o controle de máquinas

            // Exibe as informações da máquina nos controles da tela
            txtApelido.Text = apelido;
            txtFinura.Text = finura.ToString();
            txtDiametro.Text = diametro.ToString("F2");
            txtAlimentadores.Text = numeroAlimentadores.ToString();
            lblGrupo.Text = grupo;

            // Inicializa o gráfico de RPM
            InicializarGrafico(maquinaId);

            // Inicia o Timer para atualizar o gráfico periodicamente
            IniciarTimer();
        }

        private void InicializarGrafico(int maquinaId)
        {
            // Configura o gráfico
            chartStatus.Series.Clear();
            chartStatus.Titles.Clear();
            chartStatus.Titles.Add("RPM da Máquina em Função do Tempo");

            // Adiciona a série para o gráfico de linha
            Series serieRPM = new Series("RPM")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Int32, // Eixo Y será o RPM (valores contínuos)
                BorderWidth = 3
            };
            chartStatus.Series.Add(serieRPM);

            // Obtém os dados reais do banco
            List<Tuple<DateTime, int>> dadosHistorico = controleMaquinas.ObterHistoricoRPMMaquina(maquinaId);

            // Filtra os dados para a última 1 hora
            DateTime agora = DateTime.Now;
            var dadosUltimaHora = dadosHistorico.Where(d => d.Item1 >= agora.AddHours(-1)).ToList();

            // Adiciona os dados filtrados ao gráfico
            foreach (var dado in dadosUltimaHora)
            {
                serieRPM.Points.AddXY(dado.Item1, dado.Item2);
            }

            // Configura o eixo X (tempo)
            var axisX = chartStatus.ChartAreas[0].AxisX;
            axisX.LabelStyle.Format = "HH:mm"; // Formato mais enxuto para intervalos menores
            axisX.Title = "Tempo";
            axisX.IntervalType = DateTimeIntervalType.Minutes;
            axisX.Interval = 5;
            axisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            axisX.LabelStyle.Angle = -45;
            axisX.LabelStyle.IsEndLabelVisible = true;

            // Define a visualização mínima e máxima do eixo X para a última 1 hora
            axisX.Minimum = agora.AddHours(-1).ToOADate();
            axisX.Maximum = agora.ToOADate();

            // Configurações de zoom e rolagem
            axisX.ScaleView.Zoomable = true;
            axisX.ScrollBar.Enabled = true;
            axisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Minutes;
            axisX.ScaleView.SmallScrollSize = 10;

            // Configura o eixo Y (RPM)
            var axisY = chartStatus.ChartAreas[0].AxisY;
            axisY.Title = "RPM";
            axisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            axisY.Minimum = 0;
            axisY.Maximum = 100; // Ajuste conforme o valor máximo do RPM

            // Habilitar pan e zoom no gráfico
            chartStatus.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartStatus.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartStatus.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartStatus.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartStatus.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartStatus.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chartStatus.MouseWheel += ChartStatus_MouseWheel;
        }

        private void AdicionarDados(Series serie, int maquinaId)
        {
            // Obtém os dados de RPM do banco de dados
            List<Tuple<DateTime, int>> dadosHistorico = controleMaquinas.ObterHistoricoRPMMaquina(maquinaId);

            // Limpa pontos anteriores no gráfico
            serie.Points.Clear();

            // Adiciona os dados ao gráfico
            foreach (var dado in dadosHistorico)
            {
                serie.Points.AddXY(dado.Item1, dado.Item2);
            }
        }

        private void ChartStatus_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chartStatus.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chartStatus.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0)
                {
                    double xMin = chartStatus.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chartStatus.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double posXStart = chartStatus.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);

                    chartStatus.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart - (xMax - xMin) / 4, posXStart + (xMax - xMin) / 4);
                }
            }
            catch { }
        }

        private void IniciarTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 60000
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AdicionarDados(chartStatus.Series[0], maquinaId);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada de dados
                if (!int.TryParse(txtFinura.Text, out int finura))
                {
                    MessageBox.Show("Por favor, insira um valor válido para Finura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtAlimentadores.Text, out int numeroAlimentadores))
                {
                    MessageBox.Show("Por favor, insira um valor válido para Número de Alimentadores.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtDiametro.Text, out int diametro))
                {
                    MessageBox.Show("Por favor, insira um valor válido para Diâmetro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApelido.Text))
                {
                    MessageBox.Show("O campo Apelido não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                controleMaquinas.EditarMaquina(maquinaId, finura, numeroAlimentadores, diametro, txtApelido.Text);

                // Exibir mensagem de sucesso
                MessageBox.Show("Informações da máquina atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tratamento de erro
                MessageBox.Show($"Ocorreu um erro ao tentar salvar as informações da máquina: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
