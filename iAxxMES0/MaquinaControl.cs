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
    public partial class MaquinaControl : UserControl
    {
        public int MaquinaId { get; set; }
        public string Apelido { get; set; }
        public string Grupo { get; set; }
        public int RPM { get; set; }
        public string Status { get; set; }
        public string Motivo_Parada { get; set; }

        public MaquinaControl()
        {
            InitializeComponent();
        }

        public void AtualizarDados(string apelido, string grupo, int rpm, string status, string motivo_parada)
        {
            lblApelido.Text = apelido;
            lblApelido.Text = lblApelido.Text.ToUpper();
            lblStatus.Text = status;
            lblStatus.Text = lblStatus.Text.ToUpper();
            lblGrupo.Text = grupo;

            // Alterar a cor do Status para fácil visualização
            switch (status.ToLower())
            {
                case "rodando":
                    pnlStatus.BackColor = Color.Green;
                    lblDesc.Text = $"{rpm} RPM";
                    break;
                case "parada":
                    pnlStatus.BackColor = Color.Red;
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
                    pnlStatus.BackColor = Color.Gray;
                    lblDesc.Visible = false;
                    break;
            }
        }
    }
}
