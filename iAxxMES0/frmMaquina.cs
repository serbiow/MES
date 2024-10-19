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
    public partial class frmMaquina : Form
    {
        public frmMaquina(string apelido, int finura, decimal diametro, int numeroAlimentadores, string grupo)
        {
            InitializeComponent();

            // Exibe as informações da máquina nos controles da tela
            lblApelido.Text = apelido;
            lblFinura.Text = finura.ToString();
            lblDiametro.Text = diametro.ToString("F2"); // Exibe com 2 casas decimais
            lblAlimentadores.Text = numeroAlimentadores.ToString();
            lblGrupo.Text = grupo;
        }
    }
}
