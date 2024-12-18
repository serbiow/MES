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
        private DateTimePicker dtpPeriodoFim;
        private DateTimePicker dtpPeriodoInicio;
        private Label label5;
        private Button btnGerarDatas;
        private ListBox lstDatasSelecionadas;
        private Label label6;
        ControleCalendario controleCalendario = new ControleCalendario();

        public frmCadCalendario()
        {
            InitializeComponent();
            CarregarCalendarios();
            dtpPeriodoInicio.Value = DateTime.Today;
            dtpPeriodoFim.Value = DateTime.Today;
            dtpDataEspecifica.Value = DateTime.Today;
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
            cbxCalendario = new ComboBox();
            dtpPeriodoFim = new DateTimePicker();
            dtpPeriodoInicio = new DateTimePicker();
            label5 = new Label();
            btnGerarDatas = new Button();
            lstDatasSelecionadas = new ListBox();
            label6 = new Label();
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
            cbxDiaSemana.Location = new Point(12, 145);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new Size(189, 23);
            cbxDiaSemana.TabIndex = 2;
            cbxDiaSemana.Visible = false;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDiaSemana.Location = new Point(12, 122);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(112, 20);
            lblDiaSemana.TabIndex = 3;
            lblDiaSemana.Text = "Dia da Semana";
            lblDiaSemana.Visible = false;
            // 
            // dtpDataEspecifica
            // 
            dtpDataEspecifica.Format = DateTimePickerFormat.Short;
            dtpDataEspecifica.Location = new Point(12, 145);
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
            lblDataEspecifica.Location = new Point(12, 122);
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
            label3.Location = new Point(253, 93);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 17;
            label3.Text = "Fim";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 224);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Motivo da indisponibilidade...";
            txtMotivo.Size = new Size(341, 112);
            txtMotivo.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 19;
            label4.Text = "Motivo (opcional)";
            // 
            // chbDiaInteiro
            // 
            chbDiaInteiro.AutoSize = true;
            chbDiaInteiro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            chbDiaInteiro.Location = new Point(253, 174);
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
            btnSalvar.Location = new Point(103, 342);
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
            mtxtFinal.Location = new Point(253, 116);
            mtxtFinal.Mask = "00:00";
            mtxtFinal.Name = "mtxtFinal";
            mtxtFinal.Size = new Size(100, 23);
            mtxtFinal.TabIndex = 23;
            mtxtFinal.ValidatingType = typeof(DateTime);
            // 
            // cbxCalendario
            // 
            cbxCalendario.FormattingEnabled = true;
            cbxCalendario.Location = new Point(12, 87);
            cbxCalendario.Name = "cbxCalendario";
            cbxCalendario.Size = new Size(121, 23);
            cbxCalendario.TabIndex = 24;
            // 
            // dtpPeriodoFim
            // 
            dtpPeriodoFim.Format = DateTimePickerFormat.Short;
            dtpPeriodoFim.Location = new Point(253, 145);
            dtpPeriodoFim.Name = "dtpPeriodoFim";
            dtpPeriodoFim.Size = new Size(100, 23);
            dtpPeriodoFim.TabIndex = 25;
            dtpPeriodoFim.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtpPeriodoInicio
            // 
            dtpPeriodoInicio.Format = DateTimePickerFormat.Short;
            dtpPeriodoInicio.Location = new Point(253, 61);
            dtpPeriodoInicio.Name = "dtpPeriodoInicio";
            dtpPeriodoInicio.Size = new Size(100, 23);
            dtpPeriodoInicio.TabIndex = 26;
            dtpPeriodoInicio.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(12, 64);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 27;
            label5.Text = "Calendário";
            // 
            // btnGerarDatas
            // 
            btnGerarDatas.BackColor = Color.FromArgb(46, 53, 60);
            btnGerarDatas.ForeColor = Color.White;
            btnGerarDatas.Location = new Point(405, 342);
            btnGerarDatas.Name = "btnGerarDatas";
            btnGerarDatas.Size = new Size(150, 52);
            btnGerarDatas.TabIndex = 28;
            btnGerarDatas.Text = "Gerar Datas";
            btnGerarDatas.UseVisualStyleBackColor = false;
            btnGerarDatas.Click += btnGerarDatas_Click;
            // 
            // lstDatasSelecionadas
            // 
            lstDatasSelecionadas.FormattingEnabled = true;
            lstDatasSelecionadas.ItemHeight = 15;
            lstDatasSelecionadas.Location = new Point(388, 32);
            lstDatasSelecionadas.Name = "lstDatasSelecionadas";
            lstDatasSelecionadas.Size = new Size(185, 304);
            lstDatasSelecionadas.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(388, 9);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 30;
            label6.Text = "Datas Selecionadas";
            // 
            // frmCadCalendario
            // 
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(588, 408);
            Controls.Add(label6);
            Controls.Add(lstDatasSelecionadas);
            Controls.Add(btnGerarDatas);
            Controls.Add(label5);
            Controls.Add(dtpPeriodoInicio);
            Controls.Add(dtpPeriodoFim);
            Controls.Add(cbxCalendario);
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
            MaximumSize = new Size(604, 447);
            MinimumSize = new Size(604, 447);
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
        private ComboBox cbxCalendario;
        private ComboBox cbxTipo;

        // Método para carregar a lista de calendários no ComboBox
        private void CarregarCalendarios()
        {
            try
            {
                List<Calendario> calendarios = controleCalendario.ObterTodosCalendarios();
                cbxCalendario.DisplayMember = "Nome";
                cbxCalendario.ValueMember = "Id";
                cbxCalendario.DataSource = calendarios;

                if (calendarios.Count == 0)
                {
                    MessageBox.Show("Nenhum calendário disponível. Cadastre um calendário primeiro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar calendários: {ex.Message}");
            }
        }

        private DayOfWeek DiaSemanaParaDayOfWeek(string diaSemana)
        {
            return diaSemana switch
            {
                "Domingo" => DayOfWeek.Sunday,
                "Segunda" => DayOfWeek.Monday,
                "Terça" => DayOfWeek.Tuesday,
                "Quarta" => DayOfWeek.Wednesday,
                "Quinta" => DayOfWeek.Thursday,
                "Sexta" => DayOfWeek.Friday,
                "Sábado" => DayOfWeek.Saturday,
                _ => throw new ArgumentException("Dia da semana inválido")
            };
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedItem?.ToString() == "Semanal")
            {
                lblDiaSemana.Visible = true;
                cbxDiaSemana.Visible = true;

                lblDataEspecifica.Visible = false;
                dtpDataEspecifica.Visible = false;
            }
            else
            {
                lblDiaSemana.Visible = false;
                cbxDiaSemana.Visible = false;

                lblDataEspecifica.Visible = true;
                dtpDataEspecifica.Visible = true;
            }
        }

        private void chbDiaInteiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDiaInteiro.Checked)
            {
                mtxtInicio.Text = "00:00";
                mtxtFinal.Text = "23:59";

                mtxtInicio.Enabled = false;
                mtxtFinal.Enabled = false;
            }
            else
            {
                mtxtInicio.Text = "";
                mtxtFinal.Text = "";

                mtxtInicio.Enabled = true;
                mtxtFinal.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxCalendario.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um calendário.");
                return;
            }

            int calendarioId = (int)cbxCalendario.SelectedValue;

            foreach (DateTime data in lstDatasSelecionadas.Items)
            {
                var indisponibilidade = new Indisponibilidade
                {
                    DataEspecifica = data,
                    HorarioInicio = TimeSpan.Parse(mtxtInicio.Text),
                    HorarioFim = TimeSpan.Parse(mtxtFinal.Text),
                    Motivo = txtMotivo.Text
                };

                try
                {
                    controleDisponibilidade.AdicionarIndisponibilidade(indisponibilidade, calendarioId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar indisponibilidade para {data.ToShortDateString()}: {ex.Message}");
                }
            }

            MessageBox.Show("Indisponibilidades salvas com sucesso!");
        }

        private void btnGerarDatas_Click(object sender, EventArgs e)
        {
            lstDatasSelecionadas.Items.Clear();

            if (cbxDiaSemana.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um dia da semana.");
                return;
            }

            DayOfWeek diaSelecionado = DiaSemanaParaDayOfWeek(cbxDiaSemana.SelectedItem.ToString());
            DateTime dataInicio = dtpPeriodoInicio.Value.Date;
            DateTime dataFim = dtpPeriodoFim.Value.Date;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data de início não pode ser maior que a data de fim.");
                return;
            }

            DateTime dataAtual = dataInicio;
            while (dataAtual <= dataFim)
            {
                if (dataAtual.DayOfWeek == diaSelecionado)
                {
                    lstDatasSelecionadas.Items.Add(dataAtual);
                }
                dataAtual = dataAtual.AddDays(1);
            }

            if (lstDatasSelecionadas.Items.Count == 0)
            {
                MessageBox.Show("Nenhuma data encontrada para o dia da semana selecionado no período informado.");
            }
        }
    }
}
