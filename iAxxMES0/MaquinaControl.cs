using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iAxxMES0
{
    public partial class MaquinaControl : UserControl
    {
        public int MaquinaId { get; set; }
        public string Apelido { get; set; }
        public string Grupo { get; set; }
        public int RPM { get; set; }
        public string Status { get; set; }
        public string Motivo_Parada { get; set; }
        public int Finura { get; set; }
        public int Diametro { get; set; }
        public int NumeroAlimentadores { get; set; }

        // Variáveis para armazenar o status anterior e o horário de início do status atual
        private string statusAnterior;
        private DateTime dataHoraStatusAnterior;

        public MaquinaControl()
        {
            InitializeComponent();
            this.Click += MaquinaControl_Click;
            // Para detectar cliques em qualquer parte do controle
            foreach (Control control in this.Controls)
            {
                control.Click += MaquinaControl_Click;
            }
        }

        private void ExibirDetalhesMaquina()
        {
            // Garante que Apelido e Grupo estão preenchidos corretamente
            if (string.IsNullOrEmpty(this.Apelido) || string.IsNullOrEmpty(this.Grupo))
            {
                MessageBox.Show("Os dados da máquina não estão disponíveis corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o frmMaquina e passa os dados da máquina
            frmMaquina detalhesMaquina = new frmMaquina(this.Apelido, this.Finura, this.Diametro, this.NumeroAlimentadores, this.Grupo, this.MaquinaId);
            detalhesMaquina.ShowDialog();
        }

        public void AtualizarDados(string apelido, string grupo, int rpm, string status, string motivo_parada, int diametro,
                                   int finura, int numero_alimentadores, DateTime dataHoraStatus)
        {
            this.Apelido = apelido.ToUpper();
            this.Grupo = grupo;
            this.Diametro = diametro;
            this.Finura = finura;
            this.NumeroAlimentadores = numero_alimentadores;

            lblApelido.Text = apelido.ToUpper();
            lblStatus.Text = status.ToUpper();
            lblGrupo.Text = grupo;

            // Verifica se o status mudou. Se mudou, atualiza o horário de início do novo status.
            if (statusAnterior != status)
            {
                statusAnterior = status;
                dataHoraStatusAnterior = dataHoraStatus;
            }

            // Ajusta a cor e descrição do status
            switch (status.ToLower())
            {
                case "rodando":
                    pnlStatus.BackColor = Color.Green;
                    lblStatus.ForeColor = Color.White;
                    lblTempoStatus.ForeColor = Color.White;
                    lblDesc.Text = $"{rpm} RPM";
                    break;
                case "parada":
                    pnlStatus.BackColor = Color.Red;
                    lblStatus.ForeColor = Color.White;
                    lblTempoStatus.ForeColor = Color.White;
                    lblDesc.Text = motivo_parada;
                    break;
                case "sem programação":
                    pnlStatus.BackColor = Color.Gray;
                    lblDesc.Visible = false;
                    break;
                case "carga de fio":
                    pnlStatus.BackColor = Color.Orange;
                    lblDesc.Visible = false;
                    break;
                case "setup":
                    pnlStatus.BackColor = Color.LightBlue;
                    lblDesc.Visible = false;
                    break;
                default:
                    pnlStatus.BackColor = Color.White;
                    lblDesc.Visible = false;
                    break;
            }

            // Calcula o tempo em que a máquina está no status atual
            TimeSpan tempoStatus = DateTime.Now - dataHoraStatusAnterior;

            // Exibe "1d" se passou mais de 1 dia, caso contrário exibe horas e minutos
            if (tempoStatus.TotalDays >= 1)
            {
                lblTempoStatus.Text = $"{Math.Floor(tempoStatus.TotalDays)}d {tempoStatus.Hours}h {tempoStatus.Minutes}min";
            }
            else
            {
                lblTempoStatus.Text = $"{tempoStatus.Hours}h {tempoStatus.Minutes}min";
            }
        }

        private void MaquinaControl_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void lblApelido_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void lblStatus_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void lblGrupo_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void lblDesc_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void lblTempoStatus_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
        private void panel2_Click(object sender, EventArgs e) => ExibirDetalhesMaquina();
    }
}
