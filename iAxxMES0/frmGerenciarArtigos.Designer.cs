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
            txtArtigo = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            clbFibras = new CheckedListBox();
            numRpmMax = new NumericUpDown();
            numRpmMin = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            lblDescArtigo = new Label();
            btnLimpar = new Button();
            txtDescArtigo = new TextBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            btnSalvar = new Button();
            clbMaquinas = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            sairToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeIndisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCalendáriosToolStripMenuItem = new ToolStripMenuItem();
            visualizarCalendárioToolStripMenuItem = new ToolStripMenuItem();
            calendárioDeDisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            supervisaoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarGruposToolStripMenuItem = new ToolStripMenuItem();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRpmMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRpmMin).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            panel3.Location = new Point(3, 671);
            panel3.Name = "panel3";
            panel3.Size = new Size(1011, 338);
            panel3.TabIndex = 1;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(113, 65);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(98, 32);
            btnListAll.TabIndex = 8;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            // 
            // dgvArtigos
            // 
            dgvArtigos.AllowUserToAddRows = false;
            dgvArtigos.AllowUserToDeleteRows = false;
            dgvArtigos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtigos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtigos.Location = new Point(9, 103);
            dgvArtigos.Name = "dgvArtigos";
            dgvArtigos.ReadOnly = true;
            dgvArtigos.Size = new Size(993, 226);
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
            btnBuscar.Location = new Point(9, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtNomeArtigo
            // 
            txtNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNomeArtigo.Location = new Point(9, 36);
            txtNomeArtigo.Name = "txtNomeArtigo";
            txtNomeArtigo.PlaceholderText = "Nome do Artigo";
            txtNomeArtigo.Size = new Size(202, 23);
            txtNomeArtigo.TabIndex = 1;
            // 
            // lblNomeArtigo
            // 
            lblNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNomeArtigo.AutoSize = true;
            lblNomeArtigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeArtigo.ForeColor = Color.Black;
            lblNomeArtigo.Location = new Point(9, 14);
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
            label2.Size = new Size(1011, 30);
            label2.TabIndex = 28;
            label2.Text = "Gerenciar Artigos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArtigo
            // 
            txtArtigo.Location = new Point(6, 31);
            txtArtigo.Name = "txtArtigo";
            txtArtigo.PlaceholderText = "Nome do Artigo";
            txtArtigo.Size = new Size(216, 23);
            txtArtigo.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(clbFibras);
            panel1.Controls.Add(numRpmMax);
            panel1.Controls.Add(numRpmMin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtArtigo);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblDescArtigo);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(txtDescArtigo);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 626);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(165, 293);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 37;
            label5.Text = "Fibras:";
            // 
            // clbFibras
            // 
            clbFibras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbFibras.FormattingEnabled = true;
            clbFibras.Location = new Point(165, 315);
            clbFibras.MultiColumn = true;
            clbFibras.Name = "clbFibras";
            clbFibras.Size = new Size(266, 94);
            clbFibras.TabIndex = 12;
            // 
            // numRpmMax
            // 
            numRpmMax.Location = new Point(6, 383);
            numRpmMax.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numRpmMax.Name = "numRpmMax";
            numRpmMax.Size = new Size(110, 23);
            numRpmMax.TabIndex = 36;
            // 
            // numRpmMin
            // 
            numRpmMin.Location = new Point(6, 315);
            numRpmMin.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numRpmMin.Name = "numRpmMin";
            numRpmMin.Size = new Size(110, 23);
            numRpmMin.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 361);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 32;
            label4.Text = "RPM Máximo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 293);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 31;
            label3.Text = "RPM Mínimo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 30;
            label1.Text = "Nome do artigo:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(117, 572);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 32);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblDescArtigo
            // 
            lblDescArtigo.AutoSize = true;
            lblDescArtigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescArtigo.ForeColor = Color.Black;
            lblDescArtigo.Location = new Point(6, 75);
            lblDescArtigo.Name = "lblDescArtigo";
            lblDescArtigo.Size = new Size(164, 19);
            lblDescArtigo.TabIndex = 25;
            lblDescArtigo.Text = "Descrição do artigo:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(228, 572);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtDescArtigo
            // 
            txtDescArtigo.Location = new Point(6, 97);
            txtDescArtigo.Multiline = true;
            txtDescArtigo.Name = "txtDescArtigo";
            txtDescArtigo.PlaceholderText = "Descrição do Artigo";
            txtDescArtigo.Size = new Size(438, 162);
            txtDescArtigo.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(339, 572);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 32);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(46, 53, 60);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(6, 572);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 33);
            tableLayoutPanel2.MinimumSize = new Size(0, 500);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1011, 632);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(clbMaquinas);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(463, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 626);
            panel2.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(434, 466);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // clbMaquinas
            // 
            clbMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbMaquinas.FormattingEnabled = true;
            clbMaquinas.Location = new Point(3, 9);
            clbMaquinas.MultiColumn = true;
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(536, 454);
            clbMaquinas.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(1017, 1012);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.FromArgb(197, 202, 208);
            sairToolStripMenuItem.ForeColor = Color.Black;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
            // 
            // cadastroDeIndisponibilidadeToolStripMenuItem
            // 
            cadastroDeIndisponibilidadeToolStripMenuItem.Name = "cadastroDeIndisponibilidadeToolStripMenuItem";
            cadastroDeIndisponibilidadeToolStripMenuItem.Size = new Size(231, 22);
            cadastroDeIndisponibilidadeToolStripMenuItem.Text = "Cadastro de Indisponibilidade";
            cadastroDeIndisponibilidadeToolStripMenuItem.Click += cadastroDeIndisponibilidadeToolStripMenuItem_Click;
            // 
            // gerenciarCalendáriosToolStripMenuItem
            // 
            gerenciarCalendáriosToolStripMenuItem.Name = "gerenciarCalendáriosToolStripMenuItem";
            gerenciarCalendáriosToolStripMenuItem.Size = new Size(231, 22);
            gerenciarCalendáriosToolStripMenuItem.Text = "Gerenciar Calendários";
            gerenciarCalendáriosToolStripMenuItem.Click += gerenciarCalendáriosToolStripMenuItem_Click;
            // 
            // visualizarCalendárioToolStripMenuItem
            // 
            visualizarCalendárioToolStripMenuItem.Name = "visualizarCalendárioToolStripMenuItem";
            visualizarCalendárioToolStripMenuItem.Size = new Size(231, 22);
            visualizarCalendárioToolStripMenuItem.Text = "Visualizar Calendário";
            visualizarCalendárioToolStripMenuItem.Click += visualizarCalendárioToolStripMenuItem_Click;
            // 
            // calendárioDeDisponibilidadeToolStripMenuItem
            // 
            calendárioDeDisponibilidadeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarCalendárioToolStripMenuItem, gerenciarCalendáriosToolStripMenuItem, cadastroDeIndisponibilidadeToolStripMenuItem });
            calendárioDeDisponibilidadeToolStripMenuItem.Name = "calendárioDeDisponibilidadeToolStripMenuItem";
            calendárioDeDisponibilidadeToolStripMenuItem.Size = new Size(177, 20);
            calendárioDeDisponibilidadeToolStripMenuItem.Text = "Calendário de Disponibilidade";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(125, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, cadastrarToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(197, 202, 208);
            menuStrip1.Items.AddRange(new ToolStripItem[] { supervisaoToolStripMenuItem, gerenciarGruposToolStripMenuItem, usuáriosToolStripMenuItem, calendárioDeDisponibilidadeToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1017, 24);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // supervisaoToolStripMenuItem
            // 
            supervisaoToolStripMenuItem.Name = "supervisaoToolStripMenuItem";
            supervisaoToolStripMenuItem.Size = new Size(76, 20);
            supervisaoToolStripMenuItem.Text = "Supervisão";
            supervisaoToolStripMenuItem.Click += supervisaoToolStripMenuItem_Click_1;
            // 
            // gerenciarGruposToolStripMenuItem
            // 
            gerenciarGruposToolStripMenuItem.Name = "gerenciarGruposToolStripMenuItem";
            gerenciarGruposToolStripMenuItem.Size = new Size(110, 20);
            gerenciarGruposToolStripMenuItem.Text = "Gerenciar Grupos";
            gerenciarGruposToolStripMenuItem.Click += gerenciarGruposToolStripMenuItem_Click;
            // 
            // frmGerenciarArtigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(1017, 1036);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGerenciarArtigos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerenciarArtigo";
            WindowState = FormWindowState.Maximized;
            Load += frmGerenciarArtigos_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRpmMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRpmMin).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btnListAll;
        private Label label2;
        private TextBox txtArtigo;
        private Panel panel1;
        private Button btnEditar;
        private Label lblDescArtigo;
        private Button btnBuscar;
        private Button btnLimpar;
        private TextBox txtDescArtigo;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Label lblNomeArtigo;
        private TextBox txtNomeArtigo;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button btnSalvar;
        private CheckedListBox clbMaquinas;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem cadastroDeIndisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem gerenciarCalendáriosToolStripMenuItem;
        private ToolStripMenuItem visualizarCalendárioToolStripMenuItem;
        private ToolStripMenuItem calendárioDeDisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem supervisaoToolStripMenuItem;
        private DataGridView dgvArtigos;
        private ToolStripMenuItem gerenciarGruposToolStripMenuItem;
        private Label label1;
        private Label label4;
        private Label label3;
        private NumericUpDown numRpmMax;
        private NumericUpDown numRpmMin;
        private CheckedListBox clbFibras;
        private Label label5;
    }
}