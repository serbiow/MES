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
        private List<MaquinaControl> listaMaquinas; // Lista para armazenar os controles de cada máquina
        private System.Windows.Forms.Timer updateTimer; // Especificando o namespace completo por conta de ambiguidade

        public frmDashboard()
        {
            InitializeComponent();
            controleMaquinas = new ControleMaquinas();
            listaMaquinas = new List<MaquinaControl>();

            // Criar controles para todas as máquinas e adicionar ao painel
            CarregarMaquinas();

            // Configurar o timer para atualizações periódicas
            updateTimer = new System.Windows.Forms.Timer(); // Especificando o namespace aqui também
            updateTimer.Interval = 5000; // Atualizar a cada 5 segundos
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Atualizar os dados das máquinas a cada intervalo do Timer
            AtualizarDadosMaquinas();
        }

        private async void AtualizarDadosMaquinas()
        {
            // Obter os dados mais recentes do banco de dados
            List<Maquina> maquinasAtualizadas = await controleMaquinas.ObterDadosAtualizadosAsync();

            // Atualizar os controles
            foreach (var maquinaAtualizada in maquinasAtualizadas)
            {
                MaquinaControl maquinaControl = listaMaquinas.FirstOrDefault(m => m.MaquinaId == maquinaAtualizada.Id);
                if (maquinaControl != null)
                {
                    maquinaControl.AtualizarDados(maquinaAtualizada.Apelido, maquinaAtualizada.RPM, maquinaAtualizada.Status);
                }
            }
        }

        private void AbrirDetalhesMaquina(int maquinaId)
        {
            // Abrir um novo formulário com os detalhes da máquina selecionada
            //DetalhesMaquinaForm detalhesForm = new DetalhesMaquinaForm(maquinaId);
            //detalhesForm.Show();
        }

        private void CarregarMaquinas()
        {
            List<Maquina> maquinas = controleMaquinas.ObterTodasMaquinas();

            foreach (var maquina in maquinas)
            {
                MaquinaControl maquinaControl = new MaquinaControl
                {
                    MaquinaId = maquina.Id
                };

                // Configurar o evento de clique para abrir a tela de detalhes da máquina
                maquinaControl.Click += (sender, e) => AbrirDetalhesMaquina(maquina.Id);

                // Atualizar o controle com as informações da máquina
                maquinaControl.AtualizarDados(maquina.Apelido, maquina.RPM, maquina.Status);

                // Adicionar ao painel de layout
                flowLayoutPanelMaquinas.Controls.Add(maquinaControl);

                // Adicionar à lista de máquinas
                listaMaquinas.Add(maquinaControl);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            frmLogin TelaLogin = new frmLogin();
            TelaLogin.ShowDialog();

            //chama a conexão com o banco no início do código
            //cl_conexao c = new cl_conexao();
            //MessageBox.Show(c.conectar());
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
    }
}
