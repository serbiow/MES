using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace iAxxMES0
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            cbxTipoRelatorio = new ComboBox();
            label2 = new Label();
            cbxAgrupamento = new ComboBox();
            label3 = new Label();
            txtApelidoMaquina = new TextBox();
            dtpDataInicial = new DateTimePicker();
            label4 = new Label();
            dtpDataFinal = new DateTimePicker();
            label5 = new Label();
            dtpTimeInicial = new DateTimePicker();
            dtpTimeFinal = new DateTimePicker();
            chbWord = new CheckBox();
            chbExcel = new CheckBox();
            chbPDF = new CheckBox();
            label6 = new Label();
            btnGerarRelatorio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 3);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Relatório";
            // 
            // cbxTipoRelatorio
            // 
            cbxTipoRelatorio.FormattingEnabled = true;
            cbxTipoRelatorio.Items.AddRange(new object[] { "Relatório de RPM", "Relatório de Status", "Relatório de Eficiência" });
            cbxTipoRelatorio.Location = new Point(12, 27);
            cbxTipoRelatorio.Name = "cbxTipoRelatorio";
            cbxTipoRelatorio.Size = new Size(139, 23);
            cbxTipoRelatorio.TabIndex = 1;
            cbxTipoRelatorio.SelectedIndexChanged += cbxTipoRelatorio_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 79);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Agrupamento";
            // 
            // cbxAgrupamento
            // 
            cbxAgrupamento.FormattingEnabled = true;
            cbxAgrupamento.Items.AddRange(new object[] { "Todas as Máquinas", "Máquina específica" });
            cbxAgrupamento.Location = new Point(12, 101);
            cbxAgrupamento.Name = "cbxAgrupamento";
            cbxAgrupamento.Size = new Size(139, 23);
            cbxAgrupamento.TabIndex = 3;
            cbxAgrupamento.SelectedIndexChanged += cbxAgrupamento_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(199, 79);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 4;
            label3.Text = "Maquina";
            label3.Visible = false;
            // 
            // txtApelidoMaquina
            // 
            txtApelidoMaquina.Location = new Point(199, 101);
            txtApelidoMaquina.Name = "txtApelidoMaquina";
            txtApelidoMaquina.Size = new Size(121, 23);
            txtApelidoMaquina.TabIndex = 5;
            txtApelidoMaquina.Visible = false;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(12, 172);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(121, 23);
            dtpDataInicial.TabIndex = 6;
            dtpDataInicial.Value = new DateTime(2024, 11, 12, 20, 9, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 148);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 7;
            label4.Text = "Data e Hora Inicial";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(12, 273);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(121, 23);
            dtpDataFinal.TabIndex = 8;
            dtpDataFinal.Value = new DateTime(2024, 11, 12, 20, 9, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 249);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 9;
            label5.Text = "Data e Hora Final";
            // 
            // dtpTimeInicial
            // 
            dtpTimeInicial.Format = DateTimePickerFormat.Time;
            dtpTimeInicial.Location = new Point(12, 201);
            dtpTimeInicial.Name = "dtpTimeInicial";
            dtpTimeInicial.ShowUpDown = true;
            dtpTimeInicial.Size = new Size(121, 23);
            dtpTimeInicial.TabIndex = 12;
            // 
            // dtpTimeFinal
            // 
            dtpTimeFinal.Format = DateTimePickerFormat.Time;
            dtpTimeFinal.Location = new Point(12, 302);
            dtpTimeFinal.Name = "dtpTimeFinal";
            dtpTimeFinal.ShowUpDown = true;
            dtpTimeFinal.Size = new Size(121, 23);
            dtpTimeFinal.TabIndex = 13;
            // 
            // chbWord
            // 
            chbWord.AutoSize = true;
            chbWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chbWord.ForeColor = Color.White;
            chbWord.Location = new Point(12, 371);
            chbWord.Name = "chbWord";
            chbWord.Size = new Size(71, 25);
            chbWord.TabIndex = 14;
            chbWord.Text = "Word";
            chbWord.UseVisualStyleBackColor = true;
            // 
            // chbExcel
            // 
            chbExcel.AutoSize = true;
            chbExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chbExcel.ForeColor = Color.White;
            chbExcel.Location = new Point(12, 396);
            chbExcel.Name = "chbExcel";
            chbExcel.Size = new Size(69, 25);
            chbExcel.TabIndex = 15;
            chbExcel.Text = "Excel";
            chbExcel.UseVisualStyleBackColor = true;
            // 
            // chbPDF
            // 
            chbPDF.AutoSize = true;
            chbPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chbPDF.ForeColor = Color.White;
            chbPDF.Location = new Point(12, 421);
            chbPDF.Name = "chbPDF";
            chbPDF.Size = new Size(59, 25);
            chbPDF.TabIndex = 16;
            chbPDF.Text = "PDF";
            chbPDF.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 347);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 17;
            label6.Text = "Formatos";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.BackColor = Color.FromArgb(46, 53, 60);
            btnGerarRelatorio.ForeColor = Color.White;
            btnGerarRelatorio.Location = new Point(170, 388);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(150, 52);
            btnGerarRelatorio.TabIndex = 18;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // frmRelatorio
            // 
            BackColor = Color.FromArgb(89, 105, 120);
            ClientSize = new Size(332, 450);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(label6);
            Controls.Add(chbPDF);
            Controls.Add(chbExcel);
            Controls.Add(chbWord);
            Controls.Add(dtpTimeFinal);
            Controls.Add(dtpTimeInicial);
            Controls.Add(label5);
            Controls.Add(dtpDataFinal);
            Controls.Add(label4);
            Controls.Add(dtpDataInicial);
            Controls.Add(txtApelidoMaquina);
            Controls.Add(label3);
            Controls.Add(cbxAgrupamento);
            Controls.Add(label2);
            Controls.Add(cbxTipoRelatorio);
            Controls.Add(label1);
            MaximumSize = new Size(348, 489);
            MinimumSize = new Size(348, 489);
            Name = "frmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ComboBox cbxTipoRelatorio;
        private Label label2;
        private Label label3;
        private TextBox txtApelidoMaquina;
        private DateTimePicker dtpDataInicial;
        private Label label4;
        private DateTimePicker dtpDataFinal;
        private Label label5;
        private DateTimePicker dtpTimeInicial;
        private DateTimePicker dtpTimeFinal;
        private CheckBox chbWord;
        private CheckBox chbExcel;
        private CheckBox chbPDF;
        private Label label6;
        private Button btnGerarRelatorio;
        private ComboBox cbxAgrupamento;


        private async void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores dos campos do formulário
                string tipoRelatorio = cbxTipoRelatorio.SelectedIndex.ToString();
                switch (tipoRelatorio)
                {
                    case "0":
                        tipoRelatorio = "RPM";
                        break;
                    case "1":
                        tipoRelatorio = "Status";
                        break;
                    case "2":
                        tipoRelatorio = "Eficiência";
                        break;
                }

                string agrupamento = cbxAgrupamento.SelectedItem?.ToString();
                string maquinaId = txtApelidoMaquina.Text;
                string dataInicio = dtpDataInicial.Value.ToString("yyyy-MM-dd") + " " + dtpTimeInicial.Value.ToString("HH:mm:ss");
                string dataFim = dtpDataFinal.Value.ToString("yyyy-MM-dd") + " " + dtpTimeFinal.Value.ToString("HH:mm:ss");

                // Formatos selecionados
                var formatos = new System.Collections.Generic.List<string>();
                if (chbPDF.Checked) formatos.Add("pdf");
                if (chbExcel.Checked) formatos.Add("excel");
                if (chbWord.Checked) formatos.Add("word");

                if (string.IsNullOrEmpty(tipoRelatorio) || formatos.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione o tipo de relatório e ao menos um formato.");
                    return;
                }

                // Monta o comando para chamar o script Python
                string scriptPath = @"C:\Users\sergi\Documents\GitHub\iAxxMES_Relatorios\dist\main.exe"; // Caminho para o script Python
                string argumentos = $"--tipo_relatorio \"{tipoRelatorio}\" --data_inicio \"{dataInicio}\" --data_fim \"{dataFim}\" --formatos {string.Join(" ", formatos)}";

                if (agrupamento == "Máquina específica" && !string.IsNullOrEmpty(maquinaId))
                {
                    argumentos += $" --maquina_id {maquinaId}";
                }

                // Configura o processo para executar o script Python
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = scriptPath,
                    Arguments = argumentos,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = start, EnableRaisingEvents = true })
                {
                    process.OutputDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            Invoke(new Action(() =>
                            {
                                // Pode mostrar no console ou em um controle TextBox se desejar
                                Console.WriteLine(args.Data);
                            }));
                        }
                    };

                    process.ErrorDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            Invoke(new Action(() =>
                            {
                                MessageBox.Show("Erro ao gerar o relatório:\n" + args.Data);
                            }));
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await process.WaitForExitAsync(); // Aguarda o término do processo
                }

                MessageBox.Show("Relatório gerado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message);
            }
        }

        private void ConfigurarCampos()
        {
            if (cbxAgrupamento.SelectedIndex == 1)
            {
                label3.Visible = true;
                txtApelidoMaquina.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txtApelidoMaquina.Visible = false;
            }

            if (cbxTipoRelatorio.SelectedIndex == 2 || cbxAgrupamento.SelectedIndex == 0)
            {
                chbPDF.Enabled = false;
                chbPDF.Checked = false;
            }
            else
            {
                chbPDF.Enabled = true;
            }
        }

        private void cbxAgrupamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarCampos();
        }

        private void cbxTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarCampos();
        }
    }
}
