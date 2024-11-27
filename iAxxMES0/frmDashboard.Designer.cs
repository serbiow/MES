namespace iAxxMES0
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            menuStrip1 = new MenuStrip();
            gerenciarGruposToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cbxStatusFiltro = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblOderBy = new Label();
            cbxOrdenacao = new ComboBox();
            lblGrupos = new Label();
            cbxGrupo = new ComboBox();
            btnAplicarFiltro = new Button();
            txtRpmMax = new TextBox();
            lblStatusFiltro = new Label();
            txtFiltroApelido = new TextBox();
            lblRpmMax = new Label();
            lblFiltroNome = new Label();
            lblRpmMin = new Label();
            txtRpmMin = new TextBox();
            lblRpmFiltro = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            lblNumRodando = new Label();
            lblNumSemProg = new Label();
            lblNumParada = new Label();
            lblNumCarga = new Label();
            lblNumSetup = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanelMaquinas = new FlowLayoutPanel();
            lblStatusBanco = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanelMaquinas.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(197, 202, 208);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gerenciarGruposToolStripMenuItem, cadastroDeUsuárioToolStripMenuItem, consultarUsuáriosToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1289, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarGruposToolStripMenuItem
            // 
            gerenciarGruposToolStripMenuItem.Name = "gerenciarGruposToolStripMenuItem";
            gerenciarGruposToolStripMenuItem.Size = new Size(110, 20);
            gerenciarGruposToolStripMenuItem.Text = "Gerenciar Grupos";
            gerenciarGruposToolStripMenuItem.Click += gerenciarGruposToolStripMenuItem_Click;
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
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
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
            // cbxStatusFiltro
            // 
            cbxStatusFiltro.FormattingEnabled = true;
            cbxStatusFiltro.Items.AddRange(new object[] { "Todos", "Rodando", "Parada", "Setup", "Carga de fio", "Sem programação" });
            cbxStatusFiltro.Location = new Point(3, 27);
            cbxStatusFiltro.Name = "cbxStatusFiltro";
            cbxStatusFiltro.Size = new Size(121, 23);
            cbxStatusFiltro.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 793);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(197, 202, 208);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.MinimumSize = new Size(250, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(250, 793);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(197, 202, 208);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 144);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(197, 202, 208);
            panel4.Controls.Add(lblOderBy);
            panel4.Controls.Add(cbxOrdenacao);
            panel4.Controls.Add(lblGrupos);
            panel4.Controls.Add(cbxGrupo);
            panel4.Controls.Add(btnAplicarFiltro);
            panel4.Controls.Add(txtRpmMax);
            panel4.Controls.Add(lblStatusFiltro);
            panel4.Controls.Add(txtFiltroApelido);
            panel4.Controls.Add(cbxStatusFiltro);
            panel4.Controls.Add(lblRpmMax);
            panel4.Controls.Add(lblFiltroNome);
            panel4.Controls.Add(lblRpmMin);
            panel4.Controls.Add(txtRpmMin);
            panel4.Controls.Add(lblRpmFiltro);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 487);
            panel4.TabIndex = 2;
            // 
            // lblOderBy
            // 
            lblOderBy.AutoSize = true;
            lblOderBy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblOderBy.ForeColor = Color.Black;
            lblOderBy.Location = new Point(9, 306);
            lblOderBy.Name = "lblOderBy";
            lblOderBy.Size = new Size(99, 20);
            lblOderBy.TabIndex = 9;
            lblOderBy.Text = "Ordenar por:";
            // 
            // cbxOrdenacao
            // 
            cbxOrdenacao.FormattingEnabled = true;
            cbxOrdenacao.Items.AddRange(new object[] { "Maquina", "Status" });
            cbxOrdenacao.Location = new Point(3, 329);
            cbxOrdenacao.Name = "cbxOrdenacao";
            cbxOrdenacao.Size = new Size(121, 23);
            cbxOrdenacao.TabIndex = 6;
            // 
            // lblGrupos
            // 
            lblGrupos.AutoSize = true;
            lblGrupos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblGrupos.ForeColor = Color.Black;
            lblGrupos.Location = new Point(6, 69);
            lblGrupos.Name = "lblGrupos";
            lblGrupos.Size = new Size(57, 20);
            lblGrupos.TabIndex = 17;
            lblGrupos.Text = "Grupo:";
            // 
            // cbxGrupo
            // 
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Items.AddRange(new object[] { "Todos" });
            cbxGrupo.Location = new Point(3, 92);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(121, 23);
            cbxGrupo.TabIndex = 2;
            // 
            // btnAplicarFiltro
            // 
            btnAplicarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAplicarFiltro.BackColor = Color.FromArgb(46, 53, 60);
            btnAplicarFiltro.FlatStyle = FlatStyle.Flat;
            btnAplicarFiltro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAplicarFiltro.ForeColor = Color.White;
            btnAplicarFiltro.Location = new Point(3, 383);
            btnAplicarFiltro.Name = "btnAplicarFiltro";
            btnAplicarFiltro.Size = new Size(121, 30);
            btnAplicarFiltro.TabIndex = 7;
            btnAplicarFiltro.Text = "Aplicar Filtros";
            btnAplicarFiltro.UseVisualStyleBackColor = false;
            // 
            // txtRpmMax
            // 
            txtRpmMax.Location = new Point(49, 255);
            txtRpmMax.Name = "txtRpmMax";
            txtRpmMax.Size = new Size(72, 23);
            txtRpmMax.TabIndex = 5;
            txtRpmMax.KeyPress += txtRpmMax_KeyPress;
            // 
            // lblStatusFiltro
            // 
            lblStatusFiltro.AutoSize = true;
            lblStatusFiltro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblStatusFiltro.ForeColor = Color.Black;
            lblStatusFiltro.Location = new Point(9, 4);
            lblStatusFiltro.Name = "lblStatusFiltro";
            lblStatusFiltro.Size = new Size(57, 20);
            lblStatusFiltro.TabIndex = 8;
            lblStatusFiltro.Text = "Status:";
            // 
            // txtFiltroApelido
            // 
            txtFiltroApelido.Location = new Point(3, 153);
            txtFiltroApelido.Name = "txtFiltroApelido";
            txtFiltroApelido.Size = new Size(118, 23);
            txtFiltroApelido.TabIndex = 3;
            txtFiltroApelido.KeyPress += txtFiltroApelido_KeyPress;
            // 
            // lblRpmMax
            // 
            lblRpmMax.AutoSize = true;
            lblRpmMax.ForeColor = Color.Black;
            lblRpmMax.Location = new Point(12, 258);
            lblRpmMax.Name = "lblRpmMax";
            lblRpmMax.Size = new Size(33, 15);
            lblRpmMax.TabIndex = 7;
            lblRpmMax.Text = "Max:";
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFiltroNome.ForeColor = Color.Black;
            lblFiltroNome.Location = new Point(6, 130);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(74, 20);
            lblFiltroNome.TabIndex = 15;
            lblFiltroNome.Text = "Maquina:";
            // 
            // lblRpmMin
            // 
            lblRpmMin.AutoSize = true;
            lblRpmMin.ForeColor = Color.Black;
            lblRpmMin.Location = new Point(12, 229);
            lblRpmMin.Name = "lblRpmMin";
            lblRpmMin.Size = new Size(31, 15);
            lblRpmMin.TabIndex = 6;
            lblRpmMin.Text = "Min:";
            // 
            // txtRpmMin
            // 
            txtRpmMin.Location = new Point(49, 226);
            txtRpmMin.Name = "txtRpmMin";
            txtRpmMin.Size = new Size(72, 23);
            txtRpmMin.TabIndex = 4;
            txtRpmMin.KeyPress += txtRpmMin_KeyPress;
            // 
            // lblRpmFiltro
            // 
            lblRpmFiltro.AutoSize = true;
            lblRpmFiltro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRpmFiltro.ForeColor = Color.Black;
            lblRpmFiltro.Location = new Point(9, 203);
            lblRpmFiltro.Name = "lblRpmFiltro";
            lblRpmFiltro.Size = new Size(88, 20);
            lblRpmFiltro.TabIndex = 5;
            lblRpmFiltro.Text = "Velocidade:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 144);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblNumRodando);
            panel5.Controls.Add(lblNumSemProg);
            panel5.Controls.Add(lblNumParada);
            panel5.Controls.Add(lblNumCarga);
            panel5.Controls.Add(lblNumSetup);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 129);
            panel5.TabIndex = 5;
            // 
            // lblNumRodando
            // 
            lblNumRodando.BackColor = Color.Green;
            lblNumRodando.Font = new Font("Segoe UI", 11.25F);
            lblNumRodando.ForeColor = Color.White;
            lblNumRodando.Location = new Point(0, 18);
            lblNumRodando.Name = "lblNumRodando";
            lblNumRodando.Size = new Size(161, 22);
            lblNumRodando.TabIndex = 0;
            lblNumRodando.Text = "Rodando: 0";
            // 
            // lblNumSemProg
            // 
            lblNumSemProg.BackColor = Color.Gray;
            lblNumSemProg.Font = new Font("Segoe UI", 11.25F);
            lblNumSemProg.Location = new Point(0, 106);
            lblNumSemProg.Name = "lblNumSemProg";
            lblNumSemProg.Size = new Size(161, 22);
            lblNumSemProg.TabIndex = 4;
            lblNumSemProg.Text = "Sem programação: 0";
            // 
            // lblNumParada
            // 
            lblNumParada.BackColor = Color.Red;
            lblNumParada.Font = new Font("Segoe UI", 11.25F);
            lblNumParada.ForeColor = Color.White;
            lblNumParada.Location = new Point(0, 40);
            lblNumParada.Name = "lblNumParada";
            lblNumParada.Size = new Size(161, 22);
            lblNumParada.TabIndex = 1;
            lblNumParada.Text = "Parada(s): 0";
            // 
            // lblNumCarga
            // 
            lblNumCarga.BackColor = Color.Orange;
            lblNumCarga.Font = new Font("Segoe UI", 11.25F);
            lblNumCarga.Location = new Point(0, 84);
            lblNumCarga.Name = "lblNumCarga";
            lblNumCarga.Size = new Size(161, 22);
            lblNumCarga.TabIndex = 3;
            lblNumCarga.Text = "Carga de Fio: 0";
            // 
            // lblNumSetup
            // 
            lblNumSetup.BackColor = Color.LightBlue;
            lblNumSetup.Font = new Font("Segoe UI", 11.25F);
            lblNumSetup.Location = new Point(0, 62);
            lblNumSetup.Name = "lblNumSetup";
            lblNumSetup.Size = new Size(161, 22);
            lblNumSetup.TabIndex = 2;
            lblNumSetup.Text = "Setup: 0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(197, 202, 208);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanelMaquinas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1289, 799);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelMaquinas
            // 
            flowLayoutPanelMaquinas.AutoScroll = true;
            flowLayoutPanelMaquinas.BackColor = Color.FromArgb(197, 202, 208);
            flowLayoutPanelMaquinas.Controls.Add(lblStatusBanco);
            flowLayoutPanelMaquinas.Dock = DockStyle.Fill;
            flowLayoutPanelMaquinas.Location = new Point(203, 3);
            flowLayoutPanelMaquinas.Name = "flowLayoutPanelMaquinas";
            flowLayoutPanelMaquinas.Size = new Size(1083, 793);
            flowLayoutPanelMaquinas.TabIndex = 1;
            // 
            // lblStatusBanco
            // 
            lblStatusBanco.AutoSize = true;
            lblStatusBanco.ForeColor = Color.Red;
            lblStatusBanco.Location = new Point(3, 0);
            lblStatusBanco.Name = "lblStatusBanco";
            lblStatusBanco.Size = new Size(75, 15);
            lblStatusBanco.TabIndex = 0;
            lblStatusBanco.Text = "Status Banco";
            lblStatusBanco.Visible = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 823);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisão";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanelMaquinas.ResumeLayout(false);
            flowLayoutPanelMaquinas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ComboBox cbxStatusFiltro;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtRpmMin;
        private TextBox txtRpmMax;
        private Label lblRpmMax;
        private Label lblRpmMin;
        private Label lblRpmFiltro;
        private Label lblStatusFiltro;
        private ComboBox cbxOrdenacao;
        private Label lblOderBy;
        private PictureBox pictureBox1;
        private TextBox txtFiltroApelido;
        private Label lblFiltroNome;
        private Button btnAplicarFiltro;
        private FlowLayoutPanel flowLayoutPanelMaquinas;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblGrupos;
        private ComboBox cbxGrupo;
        private Label lblStatusBanco;
        private Panel panel2;
        private Label lblNumSemProg;
        private Label lblNumCarga;
        private Label lblNumSetup;
        private Label lblNumParada;
        private Label lblNumRodando;
        private Panel panel5;
        private ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
        private ToolStripMenuItem gerenciarGruposToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
    }
}