namespace iAxxMES0
{
    partial class frmCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            dataGridViewIndisponibilidades = new DataGridView();
            btnListAll = new Button();
            btnDelete = new Button();
            dgvCalendario = new DataGridView();
            domingo = new DataGridViewTextBoxColumn();
            segunda = new DataGridViewTextBoxColumn();
            Terça = new DataGridViewTextBoxColumn();
            quarta = new DataGridViewTextBoxColumn();
            quinta = new DataGridViewTextBoxColumn();
            sexta = new DataGridViewTextBoxColumn();
            sabado = new DataGridViewTextBoxColumn();
            btnMesAnterior = new Button();
            btnProximoMes = new Button();
            btnProximoAno = new Button();
            btnAnoAnterior = new Button();
            lblMesAno = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cmbCalendarios = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIndisponibilidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewIndisponibilidades
            // 
            dataGridViewIndisponibilidades.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIndisponibilidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIndisponibilidades.BackgroundColor = Color.White;
            dataGridViewIndisponibilidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIndisponibilidades.Location = new Point(12, 452);
            dataGridViewIndisponibilidades.Name = "dataGridViewIndisponibilidades";
            dataGridViewIndisponibilidades.Size = new Size(697, 150);
            dataGridViewIndisponibilidades.TabIndex = 2;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(604, 414);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 10;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            btnListAll.Click += btnListAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(46, 53, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(493, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCalendario
            // 
            dgvCalendario.AllowUserToAddRows = false;
            dgvCalendario.AllowUserToDeleteRows = false;
            dgvCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalendario.BackgroundColor = Color.FromArgb(197, 202, 208);
            dgvCalendario.BorderStyle = BorderStyle.None;
            dgvCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalendario.Columns.AddRange(new DataGridViewColumn[] { domingo, segunda, Terça, quarta, quinta, sexta, sabado });
            dgvCalendario.Dock = DockStyle.Fill;
            dgvCalendario.Location = new Point(0, 0);
            dgvCalendario.Name = "dgvCalendario";
            dgvCalendario.ReadOnly = true;
            dgvCalendario.Size = new Size(697, 354);
            dgvCalendario.TabIndex = 12;
            dgvCalendario.CellClick += dgvCalendario_CellClick;
            // 
            // domingo
            // 
            domingo.HeaderText = "Domingo";
            domingo.Name = "domingo";
            domingo.ReadOnly = true;
            // 
            // segunda
            // 
            segunda.HeaderText = "Segunda";
            segunda.Name = "segunda";
            segunda.ReadOnly = true;
            // 
            // Terça
            // 
            Terça.HeaderText = "Terça";
            Terça.Name = "Terça";
            Terça.ReadOnly = true;
            // 
            // quarta
            // 
            quarta.HeaderText = "Quarta";
            quarta.Name = "quarta";
            quarta.ReadOnly = true;
            // 
            // quinta
            // 
            quinta.HeaderText = "Quinta";
            quinta.Name = "quinta";
            quinta.ReadOnly = true;
            // 
            // sexta
            // 
            sexta.HeaderText = "Sexta";
            sexta.Name = "sexta";
            sexta.ReadOnly = true;
            // 
            // sabado
            // 
            sabado.HeaderText = "Sábado";
            sabado.Name = "sabado";
            sabado.ReadOnly = true;
            // 
            // btnMesAnterior
            // 
            btnMesAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMesAnterior.BackColor = Color.FromArgb(46, 53, 60);
            btnMesAnterior.FlatStyle = FlatStyle.Flat;
            btnMesAnterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMesAnterior.ForeColor = Color.White;
            btnMesAnterior.Location = new Point(123, 414);
            btnMesAnterior.Name = "btnMesAnterior";
            btnMesAnterior.Size = new Size(105, 32);
            btnMesAnterior.TabIndex = 13;
            btnMesAnterior.Text = "Mês Anterior";
            btnMesAnterior.UseVisualStyleBackColor = false;
            btnMesAnterior.Click += btnMesAnterior_Click;
            // 
            // btnProximoMes
            // 
            btnProximoMes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnProximoMes.BackColor = Color.FromArgb(46, 53, 60);
            btnProximoMes.FlatStyle = FlatStyle.Flat;
            btnProximoMes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProximoMes.ForeColor = Color.White;
            btnProximoMes.Location = new Point(234, 414);
            btnProximoMes.Name = "btnProximoMes";
            btnProximoMes.Size = new Size(105, 32);
            btnProximoMes.TabIndex = 14;
            btnProximoMes.Text = "Próximo Mês";
            btnProximoMes.UseVisualStyleBackColor = false;
            btnProximoMes.Click += btnProximoMes_Click;
            // 
            // btnProximoAno
            // 
            btnProximoAno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnProximoAno.BackColor = Color.FromArgb(46, 53, 60);
            btnProximoAno.FlatStyle = FlatStyle.Flat;
            btnProximoAno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProximoAno.ForeColor = Color.White;
            btnProximoAno.Location = new Point(345, 414);
            btnProximoAno.Name = "btnProximoAno";
            btnProximoAno.Size = new Size(105, 32);
            btnProximoAno.TabIndex = 16;
            btnProximoAno.Text = "Próximo Ano";
            btnProximoAno.UseVisualStyleBackColor = false;
            btnProximoAno.Click += btnProximoAno_Click;
            // 
            // btnAnoAnterior
            // 
            btnAnoAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnoAnterior.BackColor = Color.FromArgb(46, 53, 60);
            btnAnoAnterior.FlatStyle = FlatStyle.Flat;
            btnAnoAnterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnoAnterior.ForeColor = Color.White;
            btnAnoAnterior.Location = new Point(12, 414);
            btnAnoAnterior.Name = "btnAnoAnterior";
            btnAnoAnterior.Size = new Size(105, 32);
            btnAnoAnterior.TabIndex = 15;
            btnAnoAnterior.Text = "Ano Anterior";
            btnAnoAnterior.UseVisualStyleBackColor = false;
            btnAnoAnterior.Click += btnAnoAnterior_Click;
            // 
            // lblMesAno
            // 
            lblMesAno.Dock = DockStyle.Fill;
            lblMesAno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesAno.Location = new Point(0, 0);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(697, 39);
            lblMesAno.TabIndex = 17;
            lblMesAno.Text = "Mes/Ano";
            lblMesAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cmbCalendarios);
            panel1.Controls.Add(lblMesAno);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 39);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dgvCalendario);
            panel2.Location = new Point(12, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 354);
            panel2.TabIndex = 19;
            // 
            // cmbCalendarios
            // 
            cmbCalendarios.FormattingEnabled = true;
            cmbCalendarios.Location = new Point(3, 3);
            cmbCalendarios.Name = "cmbCalendarios";
            cmbCalendarios.Size = new Size(121, 23);
            cmbCalendarios.TabIndex = 18;
            cmbCalendarios.SelectedIndexChanged += cmbCalendarios_SelectedIndexChanged;
            // 
            // frmCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(721, 614);
            Controls.Add(btnProximoAno);
            Controls.Add(btnAnoAnterior);
            Controls.Add(btnProximoMes);
            Controls.Add(btnMesAnterior);
            Controls.Add(btnDelete);
            Controls.Add(btnListAll);
            Controls.Add(dataGridViewIndisponibilidades);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(737, 653);
            MinimumSize = new Size(737, 653);
            Name = "frmCalendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendário de Disponibilidade";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIndisponibilidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewIndisponibilidades;
        private Button btnListAll;
        private Button btnDelete;
        private DataGridView dgvCalendario;
        private DataGridViewTextBoxColumn domingo;
        private DataGridViewTextBoxColumn segunda;
        private DataGridViewTextBoxColumn Terça;
        private DataGridViewTextBoxColumn quarta;
        private DataGridViewTextBoxColumn quinta;
        private DataGridViewTextBoxColumn sexta;
        private DataGridViewTextBoxColumn sabado;
        private Button btnMesAnterior;
        private Button btnProximoMes;
        private Button btnProximoAno;
        private Button btnAnoAnterior;
        private Label lblMesAno;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cmbCalendarios;
    }
}