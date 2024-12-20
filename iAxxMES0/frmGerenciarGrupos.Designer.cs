namespace iAxxMES0
{
    partial class frmGerenciarGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarGrupos));
            lblNomeGrupo = new Label();
            btnLimpar = new Button();
            btnListAll = new Button();
            btnBuscar = new Button();
            dgvGrupos = new DataGridView();
            txtNomeGrupo = new TextBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            txtDescGrupo = new TextBox();
            lblDescGrupo = new Label();
            clbMaquinas = new CheckedListBox();
            btnEditar = new Button();
            btnSalvar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            txtGrupo = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            supervisaoToolStripMenuItem = new ToolStripMenuItem();
            artigoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarArtigosToolStripMenuItem = new ToolStripMenuItem();
            associaçãoDeArtigosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            calendárioDeDisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            visualizarCalendárioToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCalendáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeIndisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeGrupo
            // 
            lblNomeGrupo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNomeGrupo.AutoSize = true;
            lblNomeGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGrupo.ForeColor = Color.Black;
            lblNomeGrupo.Location = new Point(9, 47);
            lblNomeGrupo.Name = "lblNomeGrupo";
            lblNomeGrupo.Size = new Size(116, 19);
            lblNomeGrupo.TabIndex = 20;
            lblNomeGrupo.Text = "Buscar Grupo";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(228, 284);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(120, 98);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 8;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            btnListAll.Click += btnListAll_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(9, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dgvGrupos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(12, 656);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.Size = new Size(900, 226);
            dgvGrupos.TabIndex = 9;
            // 
            // txtNomeGrupo
            // 
            txtNomeGrupo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNomeGrupo.Location = new Point(9, 69);
            txtNomeGrupo.Name = "txtNomeGrupo";
            txtNomeGrupo.PlaceholderText = "Nome do Grupo";
            txtNomeGrupo.Size = new Size(216, 23);
            txtNomeGrupo.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(339, 284);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 32);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(46, 53, 60);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(6, 284);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDescGrupo
            // 
            txtDescGrupo.Location = new Point(6, 116);
            txtDescGrupo.Multiline = true;
            txtDescGrupo.Name = "txtDescGrupo";
            txtDescGrupo.PlaceholderText = "Descrição do Grupo";
            txtDescGrupo.Size = new Size(438, 162);
            txtDescGrupo.TabIndex = 3;
            // 
            // lblDescGrupo
            // 
            lblDescGrupo.AutoSize = true;
            lblDescGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescGrupo.ForeColor = Color.Black;
            lblDescGrupo.Location = new Point(6, 94);
            lblDescGrupo.Name = "lblDescGrupo";
            lblDescGrupo.Size = new Size(166, 19);
            lblDescGrupo.TabIndex = 25;
            lblDescGrupo.Text = "Descrição do grupo:";
            // 
            // clbMaquinas
            // 
            clbMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbMaquinas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbMaquinas.FormattingEnabled = true;
            clbMaquinas.Location = new Point(2, 21);
            clbMaquinas.MultiColumn = true;
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(444, 412);
            clbMaquinas.TabIndex = 10;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(117, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 32);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(341, 445);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.20833F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.7916679F));
            tableLayoutPanel1.Size = new Size(924, 870);
            tableLayoutPanel1.TabIndex = 29;
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
            tableLayoutPanel2.Size = new Size(918, 500);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblDescGrupo);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(txtDescGrupo);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 494);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 28;
            label2.Text = "Nome do Grupo";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(6, 43);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Nome do Grupo";
            txtGrupo.Size = new Size(216, 23);
            txtGrupo.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(clbMaquinas);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(463, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 494);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnListAll);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(lblNomeGrupo);
            panel3.Controls.Add(txtNomeGrupo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 496);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 371);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(918, 24);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(918, 24);
            label1.TabIndex = 29;
            label1.Text = "Gerenciar Grupos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { supervisaoToolStripMenuItem, artigoToolStripMenuItem, usuáriosToolStripMenuItem, calendárioDeDisponibilidadeToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // supervisaoToolStripMenuItem
            // 
            supervisaoToolStripMenuItem.Name = "supervisaoToolStripMenuItem";
            supervisaoToolStripMenuItem.Size = new Size(76, 20);
            supervisaoToolStripMenuItem.Text = "Supervisão";
            supervisaoToolStripMenuItem.Click += supervisaoToolStripMenuItem_Click_1;
            // 
            // artigoToolStripMenuItem
            // 
            artigoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarArtigosToolStripMenuItem, associaçãoDeArtigosToolStripMenuItem });
            artigoToolStripMenuItem.Name = "artigoToolStripMenuItem";
            artigoToolStripMenuItem.Size = new Size(52, 20);
            artigoToolStripMenuItem.Text = "Artigo";
            // 
            // gerenciarArtigosToolStripMenuItem
            // 
            gerenciarArtigosToolStripMenuItem.Name = "gerenciarArtigosToolStripMenuItem";
            gerenciarArtigosToolStripMenuItem.Size = new Size(190, 22);
            gerenciarArtigosToolStripMenuItem.Text = "Gerenciar Artigos";
            gerenciarArtigosToolStripMenuItem.Click += gerenciarArtigosToolStripMenuItem_Click_1;
            // 
            // associaçãoDeArtigosToolStripMenuItem
            // 
            associaçãoDeArtigosToolStripMenuItem.Name = "associaçãoDeArtigosToolStripMenuItem";
            associaçãoDeArtigosToolStripMenuItem.Size = new Size(190, 22);
            associaçãoDeArtigosToolStripMenuItem.Text = "Associação de Artigos";
            associaçãoDeArtigosToolStripMenuItem.Click += associaçãoDeArtigosToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, cadastrarToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click_1;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(125, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click_1;
            // 
            // calendárioDeDisponibilidadeToolStripMenuItem
            // 
            calendárioDeDisponibilidadeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarCalendárioToolStripMenuItem, gerenciarCalendáriosToolStripMenuItem, cadastroDeIndisponibilidadeToolStripMenuItem });
            calendárioDeDisponibilidadeToolStripMenuItem.Name = "calendárioDeDisponibilidadeToolStripMenuItem";
            calendárioDeDisponibilidadeToolStripMenuItem.Size = new Size(177, 20);
            calendárioDeDisponibilidadeToolStripMenuItem.Text = "Calendário de Disponibilidade";
            // 
            // visualizarCalendárioToolStripMenuItem
            // 
            visualizarCalendárioToolStripMenuItem.Name = "visualizarCalendárioToolStripMenuItem";
            visualizarCalendárioToolStripMenuItem.Size = new Size(231, 22);
            visualizarCalendárioToolStripMenuItem.Text = "Visualizar Calendário";
            visualizarCalendárioToolStripMenuItem.Click += visualizarCalendárioToolStripMenuItem_Click_1;
            // 
            // gerenciarCalendáriosToolStripMenuItem
            // 
            gerenciarCalendáriosToolStripMenuItem.Name = "gerenciarCalendáriosToolStripMenuItem";
            gerenciarCalendáriosToolStripMenuItem.Size = new Size(231, 22);
            gerenciarCalendáriosToolStripMenuItem.Text = "Gerenciar Calendários";
            gerenciarCalendáriosToolStripMenuItem.Click += gerenciarCalendáriosToolStripMenuItem_Click_1;
            // 
            // cadastroDeIndisponibilidadeToolStripMenuItem
            // 
            cadastroDeIndisponibilidadeToolStripMenuItem.Name = "cadastroDeIndisponibilidadeToolStripMenuItem";
            cadastroDeIndisponibilidadeToolStripMenuItem.Size = new Size(231, 22);
            cadastroDeIndisponibilidadeToolStripMenuItem.Text = "Cadastro de Indisponibilidade";
            cadastroDeIndisponibilidadeToolStripMenuItem.Click += cadastroDeIndisponibilidadeToolStripMenuItem_Click_1;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click_1;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.FromArgb(197, 202, 208);
            sairToolStripMenuItem.ForeColor = Color.Black;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // frmGerenciarGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(924, 894);
            Controls.Add(dgvGrupos);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(940, 845);
            Name = "frmGerenciarGrupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Grupos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeGrupo;
        private Button btnLimpar;
        private Button btnListAll;
        private Button btnBuscar;
        private DataGridView dgvGrupos;
        private TextBox txtNomeGrupo;
        private Button btnExcluir;
        private Button btnAdicionar;
        private TextBox txtDescGrupo;
        private Label lblDescGrupo;
        private CheckedListBox clbMaquinas;
        private Button btnEditar;
        private Button btnSalvar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox txtGrupo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem supervisaoToolStripMenuItem;
        private ToolStripMenuItem artigoToolStripMenuItem;
        private ToolStripMenuItem gerenciarArtigosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem calendárioDeDisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem visualizarCalendárioToolStripMenuItem;
        private ToolStripMenuItem gerenciarCalendáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeIndisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel panel4;
        private Label label1;
        private ToolStripMenuItem associaçãoDeArtigosToolStripMenuItem;
    }
}