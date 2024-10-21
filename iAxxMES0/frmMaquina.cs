using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lblApelido.Text = apelido;
            lblFinura.Text = finura.ToString();
            lblDiametro.Text = diametro.ToString("F2"); // Exibe com 2 casas decimais
            lblAlimentadores.Text = numeroAlimentadores.ToString();
            lblGrupo.Text = grupo;

            // Inicializa o gráfico de status
            InicializarGrafico(maquinaId);

            // Inicia o Timer para atualizar o gráfico periodicamente
            IniciarTimer();
        }

        private void InicializarGrafico(int maquinaId)
        {
            // Configura o gráfico
            chartStatus.Series.Clear(); // Limpa séries anteriores
            chartStatus.Titles.Clear();
            chartStatus.Titles.Add("Status da Máquina em Função do Tempo");

            // Adiciona a série para o gráfico de linha
            Series serieStatus = new Series("Status")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime, // Eixo X será o tempo
                YValueType = ChartValueType.Int32     // Eixo Y será o status mapeado como número
            };
            chartStatus.Series.Add(serieStatus);

            // Obtém os dados reais do banco
            List<Tuple<DateTime, int>> dadosHistorico = controleMaquinas.ObterHistoricoStatusMaquina(maquinaId);

            // Adiciona os dados ao gráfico
            foreach (var dado in dadosHistorico)
            {
                serieStatus.Points.AddXY(dado.Item1, dado.Item2);
            }

            // Configura o eixo X (tempo)
            // Configura o eixo X (tempo)
            var axisX = chartStatus.ChartAreas[0].AxisX;
            axisX.LabelStyle.Format = "dd/MM HH:mm"; // Exibir dia e horas no eixo X
            axisX.Title = "Tempo";
            axisX.IntervalType = DateTimeIntervalType.Hours;
            axisX.Interval = 0.1; // Exibir um rótulo a cada 1 hora, ajuste conforme necessário
            axisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid; // Exibe uma linha no grid para cada rótulo
            axisX.LabelStyle.Angle = -45; // Rotaciona os rótulos para evitar sobreposição
            axisX.LabelStyle.IsEndLabelVisible = true; // Garante que o último rótulo seja exibido

            // Verifica a data mínima e máxima nos dados obtidos
            if (dadosHistorico.Count > 0)
            {
                DateTime minDate = dadosHistorico.Min(d => d.Item1);
                DateTime maxDate = dadosHistorico.Max(d => d.Item1);

                // Define a visualização mínima e máxima do eixo X com base nos dados
                axisX.Minimum = minDate.ToOADate();
                axisX.Maximum = maxDate.ToOADate();
            }

            // Habilitar a barra de rolagem e zoom
            axisX.ScaleView.Zoomable = true; // Habilitar zoom para o eixo X
            axisX.ScrollBar.Enabled = true; // Habilitar a barra de rolagem para o eixo X
            axisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Hours; // Rolagem mais fluida com pequenos intervalos
            axisX.ScaleView.SmallScrollSize = 1; // Deslocar a visualização em incrementos de 1 hora

            // Configura o eixo Y (status)
            var axisY = chartStatus.ChartAreas[0].AxisY;
            axisY.Title = "Status";
            axisY.Interval = 1; // Intervalo entre valores no eixo Y
            axisY.Minimum = 0;
            axisY.Maximum = 5; // Número de status diferentes (ajustar conforme necessário)

            // Define rótulos customizados para o eixo Y
            axisY.CustomLabels.Clear();
            axisY.CustomLabels.Add(0.5, 1.5, "Rodando");
            axisY.CustomLabels.Add(1.5, 2.5, "Parada");
            axisY.CustomLabels.Add(2.5, 3.5, "Setup");
            axisY.CustomLabels.Add(3.5, 4.5, "Carga de fio");
            axisY.CustomLabels.Add(4.5, 5.5, "Sem programação");

            // Habilitar pan (arrastar) no gráfico
            chartStatus.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartStatus.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartStatus.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartStatus.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            // Definir o modo de seleção para ajustar zoom
            chartStatus.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartStatus.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            // Ativar a funcionalidade de zoom com o mouse (clique e arraste para zoom)
            chartStatus.MouseWheel += ChartStatus_MouseWheel;
        }

        private void AdicionarDados(Series serie, int maquinaId)
        {
            // Obtém os dados do banco de dados
            List<Tuple<DateTime, int>> dadosHistorico = controleMaquinas.ObterHistoricoStatusMaquina(maquinaId);

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
                if (e.Delta < 0) // Scroll para fora (zoom out)
                {
                    chartStatus.ChartAreas[0].AxisX.ScaleView.ZoomReset(); // Reseta o zoom no eixo X
                    chartStatus.ChartAreas[0].AxisY.ScaleView.ZoomReset(); // Reseta o zoom no eixo Y
                }
                else if (e.Delta > 0) // Scroll para dentro (zoom in)
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
            // Inicializa o timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // Atualiza o gráfico a cada 60 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza os dados do gráfico periodicamente
            AdicionarDados(chartStatus.Series[0], maquinaId);
        }
    }
}
