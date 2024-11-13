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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Relatório";
            // 
            // cbxTipoRelatorio
            // 
            cbxTipoRelatorio.FormattingEnabled = true;
            cbxTipoRelatorio.Items.AddRange(new object[] { "Relatório de RPM", "Relatório de Status", "Relatório de Eficiência" });
            cbxTipoRelatorio.Location = new Point(12, 27);
            cbxTipoRelatorio.Name = "cbxTipoRelatorio";
            cbxTipoRelatorio.Size = new Size(121, 23);
            cbxTipoRelatorio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Agrupamento";
            // 
            // cbxAgrupamento
            // 
            cbxAgrupamento.FormattingEnabled = true;
            cbxAgrupamento.Items.AddRange(new object[] { "Todas as Máquinas", "Máquina específica" });
            cbxAgrupamento.Location = new Point(12, 101);
            cbxAgrupamento.Name = "cbxAgrupamento";
            cbxAgrupamento.Size = new Size(121, 23);
            cbxAgrupamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 83);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Maquina";
            label3.Visible = false;
            // 
            // txtApelidoMaquina
            // 
            txtApelidoMaquina.Location = new Point(155, 101);
            txtApelidoMaquina.Name = "txtApelidoMaquina";
            txtApelidoMaquina.Size = new Size(121, 23);
            txtApelidoMaquina.TabIndex = 5;
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
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
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
            label5.Location = new Point(12, 255);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
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
            chbWord.Location = new Point(12, 371);
            chbWord.Name = "chbWord";
            chbWord.Size = new Size(55, 19);
            chbWord.TabIndex = 14;
            chbWord.Text = "Word";
            chbWord.UseVisualStyleBackColor = true;
            // 
            // chbExcel
            // 
            chbExcel.AutoSize = true;
            chbExcel.Location = new Point(12, 396);
            chbExcel.Name = "chbExcel";
            chbExcel.Size = new Size(53, 19);
            chbExcel.TabIndex = 15;
            chbExcel.Text = "Excel";
            chbExcel.UseVisualStyleBackColor = true;
            // 
            // chbPDF
            // 
            chbPDF.AutoSize = true;
            chbPDF.Location = new Point(12, 421);
            chbPDF.Name = "chbPDF";
            chbPDF.Size = new Size(47, 19);
            chbPDF.TabIndex = 16;
            chbPDF.Text = "PDF";
            chbPDF.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 17;
            label6.Text = "Formatos";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(170, 172);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(150, 268);
            btnGerarRelatorio.TabIndex = 18;
            btnGerarRelatorio.Text = "button1";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // frmRelatorio
            // 
            ClientSize = new Size(332, 570);
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
            Name = "frmRelatorio";
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


        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores dos campos do formulário
                string tipoRelatorio = cbxTipoRelatorio.SelectedItem?.ToString();
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
                string scriptPath = @"C:\Users\sergi\coisas\iAxx\dist\main.exe"; // Caminho para o script Python
                string pythonPath = @"C:\Users\sergi\AppData\Local\Programs\Python\Python312\python.exe"; // Caminho para o executável Python
                string argumentos = $"--tipo_relatorio \"{tipoRelatorio}\" --data_inicio \"{dataInicio}\" --data_fim \"{dataFim}\" --formatos {string.Join(" ", formatos)}";

                if (agrupamento == "Máquina específica" && !string.IsNullOrEmpty(maquinaId))
                {
                    argumentos += $" --maquina_id {maquinaId}";
                }

                // Configura o processo para executar o script Python
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    Arguments = $"\"{scriptPath}\" {argumentos}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string output = reader.ReadToEnd();
                        MessageBox.Show("Relatório gerado com sucesso:\n" + output);
                    }

                    using (StreamReader errorReader = process.StandardError)
                    {
                        string error = errorReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Erro ao gerar o relatório:\n" + error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message);
            }
        }
    }
}
