namespace iAxxMES0
{
    partial class frmGerenciarArtigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarArtigos));
            panel3 = new Panel();
            btnListAll = new Button();
            dgvArtigos = new DataGridView();
            btnBuscar = new Button();
            txtNomeArtigo = new TextBox();
            lblNomeArtigo = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtRpmMedio = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnEditar = new Button();
            label5 = new Label();
            clbFibras = new CheckedListBox();
            numRpmMax = new NumericUpDown();
            numRpmMin = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtArtigo = new TextBox();
            lblDescArtigo = new Label();
            txtDescArtigo = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRpmMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRpmMin).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnListAll);
            panel3.Controls.Add(dgvArtigos);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtNomeArtigo);
            panel3.Controls.Add(lblNomeArtigo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 414);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 344);
            panel3.TabIndex = 1;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(113, 71);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(98, 32);
            btnListAll.TabIndex = 12;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            btnListAll.Click += btnListAll_Click;
            // 
            // dgvArtigos
            // 
            dgvArtigos.AllowUserToAddRows = false;
            dgvArtigos.AllowUserToDeleteRows = false;
            dgvArtigos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtigos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtigos.Location = new Point(9, 109);
            dgvArtigos.Name = "dgvArtigos";
            dgvArtigos.ReadOnly = true;
            dgvArtigos.Size = new Size(970, 226);
            dgvArtigos.TabIndex = 30;
            dgvArtigos.SelectionChanged += dgvArtigos_SelectionChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(9, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 32);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNomeArtigo
            // 
            txtNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNomeArtigo.Location = new Point(9, 42);
            txtNomeArtigo.Name = "txtNomeArtigo";
            txtNomeArtigo.PlaceholderText = "Nome do Artigo";
            txtNomeArtigo.Size = new Size(202, 23);
            txtNomeArtigo.TabIndex = 10;
            // 
            // lblNomeArtigo
            // 
            lblNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNomeArtigo.AutoSize = true;
            lblNomeArtigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeArtigo.ForeColor = Color.Black;
            lblNomeArtigo.Location = new Point(9, 20);
            lblNomeArtigo.Name = "lblNomeArtigo";
            lblNomeArtigo.Size = new Size(113, 19);
            lblNomeArtigo.TabIndex = 20;
            lblNomeArtigo.Text = "Buscar Artigo";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(988, 30);
            label2.TabIndex = 28;
            label2.Text = "Gerenciar Artigos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Size = new Size(994, 761);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtRpmMedio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(clbFibras);
            panel1.Controls.Add(numRpmMax);
            panel1.Controls.Add(numRpmMin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtArtigo);
            panel1.Controls.Add(lblDescArtigo);
            panel1.Controls.Add(txtDescArtigo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 375);
            panel1.TabIndex = 29;
            // 
            // txtRpmMedio
            // 
            txtRpmMedio.Enabled = false;
            txtRpmMedio.Location = new Point(749, 31);
            txtRpmMedio.Name = "txtRpmMedio";
            txtRpmMedio.ReadOnly = true;
            txtRpmMedio.Size = new Size(110, 23);
            txtRpmMedio.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(749, 9);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 54;
            label6.Text = "rpm Médio:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnLimpar);
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(9, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 73);
            panel2.TabIndex = 52;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(46, 53, 60);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(259, 22);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(592, 22);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 32);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(481, 22);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(370, 22);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 32);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(376, 75);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 51;
            label5.Text = "Fibras:";
            // 
            // clbFibras
            // 
            clbFibras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbFibras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbFibras.FormattingEnabled = true;
            clbFibras.Location = new Point(376, 97);
            clbFibras.MultiColumn = true;
            clbFibras.Name = "clbFibras";
            clbFibras.Size = new Size(603, 172);
            clbFibras.TabIndex = 5;
            // 
            // numRpmMax
            // 
            numRpmMax.Location = new Point(865, 31);
            numRpmMax.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numRpmMax.Name = "numRpmMax";
            numRpmMax.Size = new Size(110, 23);
            numRpmMax.TabIndex = 3;
            // 
            // numRpmMin
            // 
            numRpmMin.Location = new Point(633, 31);
            numRpmMin.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numRpmMin.Name = "numRpmMin";
            numRpmMin.Size = new Size(110, 23);
            numRpmMin.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(865, 9);
            label4.Name = "label4";
            label4.Size = new Size(108, 19);
            label4.TabIndex = 48;
            label4.Text = "rpm Máximo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(633, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 47;
            label3.Text = "rpm Mínimo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 46;
            label1.Text = "Nome do artigo:";
            // 
            // txtArtigo
            // 
            txtArtigo.Location = new Point(9, 31);
            txtArtigo.Name = "txtArtigo";
            txtArtigo.PlaceholderText = "Nome do Artigo";
            txtArtigo.Size = new Size(235, 23);
            txtArtigo.TabIndex = 1;
            // 
            // lblDescArtigo
            // 
            lblDescArtigo.AutoSize = true;
            lblDescArtigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescArtigo.ForeColor = Color.Black;
            lblDescArtigo.Location = new Point(9, 75);
            lblDescArtigo.Name = "lblDescArtigo";
            lblDescArtigo.Size = new Size(164, 19);
            lblDescArtigo.TabIndex = 44;
            lblDescArtigo.Text = "Descrição do artigo:";
            // 
            // txtDescArtigo
            // 
            txtDescArtigo.Location = new Point(9, 97);
            txtDescArtigo.Multiline = true;
            txtDescArtigo.Name = "txtDescArtigo";
            txtDescArtigo.PlaceholderText = "Descrição do Artigo";
            txtDescArtigo.Size = new Size(352, 172);
            txtDescArtigo.TabIndex = 4;
            // 
            // frmGerenciarArtigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(994, 761);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1010, 800);
            MinimumSize = new Size(1010, 800);
            Name = "frmGerenciarArtigos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerenciarArtigo";
            Load += frmGerenciarArtigos_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numRpmMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRpmMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnListAll;
        private Label label2;
        private Button btnBuscar;
        private Label lblNomeArtigo;
        private TextBox txtNomeArtigo;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvArtigos;
        private Panel panel1;
        private Label label5;
        private CheckedListBox clbFibras;
        private NumericUpDown numRpmMax;
        private NumericUpDown numRpmMin;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtArtigo;
        private Button btnEditar;
        private Label lblDescArtigo;
        private Button btnLimpar;
        private TextBox txtDescArtigo;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Panel panel2;
        private Label label6;
        private TextBox txtRpmMedio;
    }
}