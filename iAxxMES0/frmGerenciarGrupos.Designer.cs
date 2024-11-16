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
            lblNomeGrupo = new Label();
            btnLimpar = new Button();
            btnListAll = new Button();
            btnBuscar = new Button();
            dgvGrupos = new DataGridView();
            txtGrupo = new TextBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            txtDescGrupo = new TextBox();
            lblDescGrupo = new Label();
            clbMaquinas = new CheckedListBox();
            btnEditar = new Button();
            btnSalvar = new Button();
            menuStrip1 = new MenuStrip();
            supervisaoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeGrupo
            // 
            lblNomeGrupo.AutoSize = true;
            lblNomeGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGrupo.ForeColor = Color.Black;
            lblNomeGrupo.Location = new Point(6, 41);
            lblNomeGrupo.Name = "lblNomeGrupo";
            lblNomeGrupo.Size = new Size(134, 19);
            lblNomeGrupo.TabIndex = 20;
            lblNomeGrupo.Text = "Nome do grupo:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(228, 353);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(804, 4);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 8;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            btnListAll.Click += btnListAll_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(6, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(216, 32);
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
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(12, 568);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.Size = new Size(900, 226);
            dgvGrupos.TabIndex = 9;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(6, 63);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(216, 23);
            txtGrupo.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(339, 353);
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
            btnAdicionar.Location = new Point(6, 353);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDescGrupo
            // 
            txtDescGrupo.Location = new Point(12, 191);
            txtDescGrupo.Multiline = true;
            txtDescGrupo.Name = "txtDescGrupo";
            txtDescGrupo.Size = new Size(438, 162);
            txtDescGrupo.TabIndex = 3;
            // 
            // lblDescGrupo
            // 
            lblDescGrupo.AutoSize = true;
            lblDescGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescGrupo.ForeColor = Color.Black;
            lblDescGrupo.Location = new Point(12, 169);
            lblDescGrupo.Name = "lblDescGrupo";
            lblDescGrupo.Size = new Size(166, 19);
            lblDescGrupo.TabIndex = 25;
            lblDescGrupo.Text = "Descrição do grupo:";
            // 
            // clbMaquinas
            // 
            clbMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clbMaquinas.FormattingEnabled = true;
            clbMaquinas.Location = new Point(71, 37);
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(376, 310);
            clbMaquinas.TabIndex = 10;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(117, 353);
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
            btnSalvar.Location = new Point(342, 353);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(197, 202, 208);
            menuStrip1.Items.AddRange(new ToolStripItem[] { supervisaoToolStripMenuItem, cadastroDeUsuárioToolStripMenuItem, consultarUsuáriosToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 24);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // supervisaoToolStripMenuItem
            // 
            supervisaoToolStripMenuItem.Name = "supervisaoToolStripMenuItem";
            supervisaoToolStripMenuItem.Size = new Size(76, 20);
            supervisaoToolStripMenuItem.Text = "Supervisão";
            supervisaoToolStripMenuItem.Click += supervisaoToolStripMenuItem_Click;
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            cadastroDeUsuárioToolStripMenuItem.BackColor = Color.FromArgb(197, 202, 208);
            cadastroDeUsuárioToolStripMenuItem.ForeColor = Color.Black;
            cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            cadastroDeUsuárioToolStripMenuItem.Size = new Size(125, 20);
            cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            cadastroDeUsuárioToolStripMenuItem.Click += cadastroDeUsuárioToolStripMenuItem_Click;
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            consultarUsuáriosToolStripMenuItem.Size = new Size(118, 20);
            consultarUsuáriosToolStripMenuItem.Text = "Consultar Usuários";
            consultarUsuáriosToolStripMenuItem.Click += consultarUsuáriosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.FromArgb(197, 202, 208);
            sairToolStripMenuItem.ForeColor = Color.Black;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(924, 806);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.MinimumSize = new Size(0, 500);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(918, 517);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(lblNomeGrupo);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtGrupo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 511);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(clbMaquinas);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(462, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 511);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnListAll);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 277);
            panel3.TabIndex = 1;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
            // 
            // frmGerenciarGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(924, 806);
            Controls.Add(menuStrip1);
            Controls.Add(lblDescGrupo);
            Controls.Add(txtDescGrupo);
            Controls.Add(dgvGrupos);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(940, 845);
            Name = "frmGerenciarGrupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Grupos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeGrupo;
        private Button btnLimpar;
        private Button btnListAll;
        private Button btnBuscar;
        private DataGridView dgvGrupos;
        private TextBox txtGrupo;
        private Button btnExcluir;
        private Button btnAdicionar;
        private TextBox txtDescGrupo;
        private Label lblDescGrupo;
        private CheckedListBox clbMaquinas;
        private Button btnEditar;
        private Button btnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
        private ToolStripMenuItem supervisaoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem relatórioToolStripMenuItem;
    }
}