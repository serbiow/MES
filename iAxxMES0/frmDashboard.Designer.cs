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
            cadastroDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cbxStatusFiltro = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            chkAutoRefresh = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            btnRefresh = new Button();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanelMaquinas = new FlowLayoutPanel();
            lblStatusBanco = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanelMaquinas.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroDeUsuárioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1294, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            cadastroDeUsuárioToolStripMenuItem.Size = new Size(125, 20);
            cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            cadastroDeUsuárioToolStripMenuItem.Click += cadastroDeUsuárioToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
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
            cbxStatusFiltro.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(chkAutoRefresh);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 1031);
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
            // chkAutoRefresh
            // 
            chkAutoRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAutoRefresh.Checked = true;
            chkAutoRefresh.CheckState = CheckState.Checked;
            chkAutoRefresh.Location = new Point(164, 3);
            chkAutoRefresh.Name = "chkAutoRefresh";
            chkAutoRefresh.Size = new Size(88, 38);
            chkAutoRefresh.TabIndex = 1;
            chkAutoRefresh.Text = "Atualização Automática";
            chkAutoRefresh.UseVisualStyleBackColor = true;
            chkAutoRefresh.CheckedChanged += chkAutoRefresh_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(252, 1031);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRefresh);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 251);
            panel3.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(168, 44);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // panel4
            // 
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
            panel4.Location = new Point(3, 260);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 768);
            panel4.TabIndex = 2;
            // 
            // lblOderBy
            // 
            lblOderBy.AutoSize = true;
            lblOderBy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOderBy.Location = new Point(9, 306);
            lblOderBy.Name = "lblOderBy";
            lblOderBy.Size = new Size(93, 20);
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
            cbxOrdenacao.TabIndex = 3;
            // 
            // lblGrupos
            // 
            lblGrupos.AutoSize = true;
            lblGrupos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupos.Location = new Point(6, 69);
            lblGrupos.Name = "lblGrupos";
            lblGrupos.Size = new Size(53, 20);
            lblGrupos.TabIndex = 17;
            lblGrupos.Text = "Grupo:";
            // 
            // cbxGrupo
            // 
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Items.AddRange(new object[] { "Grupo 1", "Grupo 2", "Grupo 3", "Grupo 4", "Grupo 5" });
            cbxGrupo.Location = new Point(3, 92);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(121, 23);
            cbxGrupo.TabIndex = 16;
            // 
            // btnAplicarFiltro
            // 
            btnAplicarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAplicarFiltro.Location = new Point(153, 4);
            btnAplicarFiltro.Name = "btnAplicarFiltro";
            btnAplicarFiltro.Size = new Size(90, 23);
            btnAplicarFiltro.TabIndex = 8;
            btnAplicarFiltro.Text = "Aplicar Filtros";
            btnAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // txtRpmMax
            // 
            txtRpmMax.Location = new Point(49, 255);
            txtRpmMax.Name = "txtRpmMax";
            txtRpmMax.Size = new Size(100, 23);
            txtRpmMax.TabIndex = 6;
            txtRpmMax.KeyPress += txtRpmMax_KeyPress;
            // 
            // lblStatusFiltro
            // 
            lblStatusFiltro.AutoSize = true;
            lblStatusFiltro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusFiltro.Location = new Point(9, 4);
            lblStatusFiltro.Name = "lblStatusFiltro";
            lblStatusFiltro.Size = new Size(52, 20);
            lblStatusFiltro.TabIndex = 8;
            lblStatusFiltro.Text = "Status:";
            // 
            // txtFiltroApelido
            // 
            txtFiltroApelido.Location = new Point(3, 153);
            txtFiltroApelido.Name = "txtFiltroApelido";
            txtFiltroApelido.Size = new Size(100, 23);
            txtFiltroApelido.TabIndex = 7;
            txtFiltroApelido.KeyPress += txtFiltroApelido_KeyPress;
            // 
            // lblRpmMax
            // 
            lblRpmMax.AutoSize = true;
            lblRpmMax.Location = new Point(12, 258);
            lblRpmMax.Name = "lblRpmMax";
            lblRpmMax.Size = new Size(33, 15);
            lblRpmMax.TabIndex = 7;
            lblRpmMax.Text = "Max:";
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltroNome.Location = new Point(6, 130);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(70, 20);
            lblFiltroNome.TabIndex = 15;
            lblFiltroNome.Text = "Maquina:";
            // 
            // lblRpmMin
            // 
            lblRpmMin.AutoSize = true;
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
            txtRpmMin.Size = new Size(100, 23);
            txtRpmMin.TabIndex = 5;
            txtRpmMin.KeyPress += txtRpmMin_KeyPress;
            // 
            // lblRpmFiltro
            // 
            lblRpmFiltro.AutoSize = true;
            lblRpmFiltro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRpmFiltro.Location = new Point(9, 203);
            lblRpmFiltro.Name = "lblRpmFiltro";
            lblRpmFiltro.Size = new Size(42, 20);
            lblRpmFiltro.TabIndex = 5;
            lblRpmFiltro.Text = "RPM:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanelMaquinas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1294, 1037);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelMaquinas
            // 
            flowLayoutPanelMaquinas.AutoScroll = true;
            flowLayoutPanelMaquinas.BackColor = SystemColors.Control;
            flowLayoutPanelMaquinas.Controls.Add(lblStatusBanco);
            flowLayoutPanelMaquinas.Dock = DockStyle.Fill;
            flowLayoutPanelMaquinas.Location = new Point(261, 3);
            flowLayoutPanelMaquinas.Name = "flowLayoutPanelMaquinas";
            flowLayoutPanelMaquinas.Size = new Size(1030, 1031);
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
            ClientSize = new Size(1294, 1061);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmDashboard_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private CheckBox chkAutoRefresh;
        private Button btnRefresh;
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
    }
}