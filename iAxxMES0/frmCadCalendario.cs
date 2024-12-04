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
    public partial class frmCadCalendario : Form
    {
        ControleDisponibilidade controleDisponibilidade = new ControleDisponibilidade();

        public frmCadCalendario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmCadCalendario));
            cbxTipo = new ComboBox();
            label1 = new Label();
            cbxDiaSemana = new ComboBox();
            lblDiaSemana = new Label();
            dtpDataEspecifica = new DateTimePicker();
            lblDataEspecifica = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMotivo = new TextBox();
            label4 = new Label();
            chbDiaInteiro = new CheckBox();
            btnSalvar = new Button();
            mtxtInicio = new MaskedTextBox();
            mtxtFinal = new MaskedTextBox();
            SuspendLayout();
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Semanal", "Específico" });
            cbxTipo.Location = new Point(12, 32);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(189, 23);
            cbxTipo.TabIndex = 0;
            cbxTipo.SelectedIndexChanged += cbxTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo de Indisponibillidade";
            // 
            // cbxDiaSemana
            // 
            cbxDiaSemana.FormattingEnabled = true;
            cbxDiaSemana.Items.AddRange(new object[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" });
            cbxDiaSemana.Location = new Point(12, 81);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new Size(189, 23);
            cbxDiaSemana.TabIndex = 2;
            cbxDiaSemana.Visible = false;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDiaSemana.Location = new Point(12, 58);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(112, 20);
            lblDiaSemana.TabIndex = 3;
            lblDiaSemana.Text = "Dia da Semana";
            lblDiaSemana.Visible = false;
            // 
            // dtpDataEspecifica
            // 
            dtpDataEspecifica.Format = DateTimePickerFormat.Short;
            dtpDataEspecifica.Location = new Point(12, 81);
            dtpDataEspecifica.Name = "dtpDataEspecifica";
            dtpDataEspecifica.Size = new Size(189, 23);
            dtpDataEspecifica.TabIndex = 4;
            dtpDataEspecifica.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpDataEspecifica.Visible = false;
            // 
            // lblDataEspecifica
            // 
            lblDataEspecifica.AutoSize = true;
            lblDataEspecifica.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDataEspecifica.Location = new Point(12, 58);
            lblDataEspecifica.Name = "lblDataEspecifica";
            lblDataEspecifica.Size = new Size(114, 20);
            lblDataEspecifica.TabIndex = 5;
            lblDataEspecifica.Text = "Data Específica";
            lblDataEspecifica.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(253, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 16;
            label2.Text = "Início";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(253, 58);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 17;
            label3.Text = "Fim";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 165);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Motivo da indisponibilidade...";
            txtMotivo.Size = new Size(341, 120);
            txtMotivo.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 19;
            label4.Text = "Motivo (opcional)";
            // 
            // chbDiaInteiro
            // 
            chbDiaInteiro.AutoSize = true;
            chbDiaInteiro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chbDiaInteiro.Location = new Point(251, 110);
            chbDiaInteiro.Name = "chbDiaInteiro";
            chbDiaInteiro.Size = new Size(102, 24);
            chbDiaInteiro.TabIndex = 20;
            chbDiaInteiro.Text = "Dia Inteiro";
            chbDiaInteiro.UseVisualStyleBackColor = true;
            chbDiaInteiro.CheckedChanged += chbDiaInteiro_CheckedChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(106, 291);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 52);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mtxtInicio
            // 
            mtxtInicio.Location = new Point(253, 32);
            mtxtInicio.Mask = "00:00";
            mtxtInicio.Name = "mtxtInicio";
            mtxtInicio.Size = new Size(100, 23);
            mtxtInicio.TabIndex = 22;
            mtxtInicio.ValidatingType = typeof(DateTime);
            // 
            // mtxtFinal
            // 
            mtxtFinal.Location = new Point(253, 81);
            mtxtFinal.Mask = "00:00";
            mtxtFinal.Name = "mtxtFinal";
            mtxtFinal.Size = new Size(100, 23);
            mtxtFinal.TabIndex = 23;
            mtxtFinal.ValidatingType = typeof(DateTime);
            // 
            // frmCadCalendario
            // 
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(365, 356);
            Controls.Add(mtxtFinal);
            Controls.Add(mtxtInicio);
            Controls.Add(btnSalvar);
            Controls.Add(chbDiaInteiro);
            Controls.Add(label4);
            Controls.Add(txtMotivo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblDataEspecifica);
            Controls.Add(dtpDataEspecifica);
            Controls.Add(lblDiaSemana);
            Controls.Add(cbxDiaSemana);
            Controls.Add(label1);
            Controls.Add(cbxTipo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(381, 395);
            MinimumSize = new Size(381, 395);
            Name = "frmCadCalendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Indisponibilidade";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ComboBox cbxDiaSemana;
        private Label lblDiaSemana;
        private DateTimePicker dtpDataEspecifica;
        private Label lblDataEspecifica;
        private Label label2;
        private Label label3;
        private TextBox txtMotivo;
        private Label label4;
        private CheckBox chbDiaInteiro;
        private Button btnSalvar;
        private MaskedTextBox mtxtInicio;
        private MaskedTextBox mtxtFinal;
        private ComboBox cbxTipo;

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedItem.ToString() == "Semanal")
            {
                // Dia da semana
                lblDiaSemana.Visible = true;
                cbxDiaSemana.Visible = true;

                // Data específica
                lblDataEspecifica.Visible = false;
                dtpDataEspecifica.Visible = false;
            }
            else
            {
                // Dia da semana
                lblDiaSemana.Visible = false;
                cbxDiaSemana.Visible = false;

                // Data específica
                lblDataEspecifica.Visible = true;
                dtpDataEspecifica.Visible = true;
            }
        }

        private void chbDiaInteiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDiaInteiro.Checked == true)
            {
                mtxtInicio.Text = "00:00:00";
                mtxtFinal.Text = "23:59:59";

                // Desabilita os campos para evitar edições
                mtxtInicio.Enabled = false;
                mtxtFinal.Enabled = false;
            }
            else
            {
                // Limpa os campos e habilita para edição
                mtxtInicio.Text = "";
                mtxtFinal.Text = "";
                mtxtInicio.Enabled = true;
                mtxtFinal.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var indisponibilidade = new Indisponibilidade
            {
                Tipo = cbxTipo.SelectedItem.ToString(),
                DiaSemana = cbxTipo.SelectedItem.ToString() == "Semanal" ? cbxDiaSemana.SelectedItem.ToString() : null,
                DataEspecifica = cbxTipo.SelectedItem.ToString() == "Específico" ? dtpDataEspecifica.Value.Date : (DateTime?)null,
                HorarioInicio = TimeSpan.Parse(mtxtInicio.Text),
                HorarioFim = TimeSpan.Parse(mtxtFinal.Text),
                Motivo = txtMotivo.Text
            };

            try
            {
                controleDisponibilidade.AdicionarIndisponibilidade(indisponibilidade);
                MessageBox.Show("Indisponibilidade salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }
    }
}
