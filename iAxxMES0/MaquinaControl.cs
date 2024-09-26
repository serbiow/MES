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
        public int RPM { get; set; }
        public string Status { get; set; }

        public MaquinaControl()
        {
            InitializeComponent();
        }

        public void AtualizarDados(string apelido, int rpm, string status)
        {
            lblApelido.Text = apelido;
            lblRPM.Text = $"{rpm} RPM";
            lblStatus.Text = status;
            lblStatus.Text = lblStatus.Text.ToUpper();

            // Alterar a cor do Status para fácil visualização
            switch (status.ToLower())
            {
                case "ligado":
                    pnlStatus.BackColor = Color.Green;
                    break;
                case "desligado":
                    pnlStatus.BackColor = Color.Gray;
                    break;
                case "alarme":
                    pnlStatus.BackColor = Color.Red;
                    break;
                default:
                    pnlStatus.BackColor = Color.Gray;
                    break;
            }
        }
    }
}
