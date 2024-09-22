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
            menuStrip1 = new MenuStrip();
            cadastroDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanelMaquinas = new FlowLayoutPanel();
            cbxStatusFiltro = new ComboBox();
            panel1 = new Panel();
            cbxOrdenacao = new ComboBox();
            lblOderBy = new Label();
            lblStatusFiltro = new Label();
            lblRpmMax = new Label();
            lblRpmMin = new Label();
            lblRpmFiltro = new Label();
            txtRpmMin = new TextBox();
            txtRpmMax = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroDeUsuárioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1167, 24);
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
            // flowLayoutPanelMaquinas
            // 
            flowLayoutPanelMaquinas.AutoScroll = true;
            flowLayoutPanelMaquinas.Dock = DockStyle.Fill;
            flowLayoutPanelMaquinas.Location = new Point(3, 109);
            flowLayoutPanelMaquinas.Name = "flowLayoutPanelMaquinas";
            flowLayoutPanelMaquinas.Size = new Size(1161, 422);
            flowLayoutPanelMaquinas.TabIndex = 1;
            // 
            // cbxStatusFiltro
            // 
            cbxStatusFiltro.FormattingEnabled = true;
            cbxStatusFiltro.Items.AddRange(new object[] { "Todos", "Ligado", "Desligado", "Alarme" });
            cbxStatusFiltro.Location = new Point(6, 18);
            cbxStatusFiltro.Name = "cbxStatusFiltro";
            cbxStatusFiltro.Size = new Size(121, 23);
            cbxStatusFiltro.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxOrdenacao);
            panel1.Controls.Add(lblOderBy);
            panel1.Controls.Add(lblStatusFiltro);
            panel1.Controls.Add(lblRpmMax);
            panel1.Controls.Add(lblRpmMin);
            panel1.Controls.Add(lblRpmFiltro);
            panel1.Controls.Add(txtRpmMin);
            panel1.Controls.Add(txtRpmMax);
            panel1.Controls.Add(cbxStatusFiltro);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 100);
            panel1.TabIndex = 0;
            // 
            // cbxOrdenacao
            // 
            cbxOrdenacao.FormattingEnabled = true;
            cbxOrdenacao.Items.AddRange(new object[] { "Apelido", "RPM", "Status" });
            cbxOrdenacao.Location = new Point(158, 18);
            cbxOrdenacao.Name = "cbxOrdenacao";
            cbxOrdenacao.Size = new Size(121, 23);
            cbxOrdenacao.TabIndex = 10;
            // 
            // lblOderBy
            // 
            lblOderBy.AutoSize = true;
            lblOderBy.Location = new Point(158, 0);
            lblOderBy.Name = "lblOderBy";
            lblOderBy.Size = new Size(74, 15);
            lblOderBy.TabIndex = 9;
            lblOderBy.Text = "Ordenar por:";
            // 
            // lblStatusFiltro
            // 
            lblStatusFiltro.AutoSize = true;
            lblStatusFiltro.Location = new Point(3, 0);
            lblStatusFiltro.Name = "lblStatusFiltro";
            lblStatusFiltro.Size = new Size(42, 15);
            lblStatusFiltro.TabIndex = 8;
            lblStatusFiltro.Text = "Status:";
            // 
            // lblRpmMax
            // 
            lblRpmMax.AutoSize = true;
            lblRpmMax.Location = new Point(158, 75);
            lblRpmMax.Name = "lblRpmMax";
            lblRpmMax.Size = new Size(33, 15);
            lblRpmMax.TabIndex = 7;
            lblRpmMax.Text = "Max:";
            // 
            // lblRpmMin
            // 
            lblRpmMin.AutoSize = true;
            lblRpmMin.Location = new Point(6, 75);
            lblRpmMin.Name = "lblRpmMin";
            lblRpmMin.Size = new Size(31, 15);
            lblRpmMin.TabIndex = 6;
            lblRpmMin.Text = "Min:";
            // 
            // lblRpmFiltro
            // 
            lblRpmFiltro.AutoSize = true;
            lblRpmFiltro.Location = new Point(6, 54);
            lblRpmFiltro.Name = "lblRpmFiltro";
            lblRpmFiltro.Size = new Size(35, 15);
            lblRpmFiltro.TabIndex = 5;
            lblRpmFiltro.Text = "RPM:";
            // 
            // txtRpmMin
            // 
            txtRpmMin.Location = new Point(43, 72);
            txtRpmMin.Name = "txtRpmMin";
            txtRpmMin.Size = new Size(100, 23);
            txtRpmMin.TabIndex = 4;
            // 
            // txtRpmMax
            // 
            txtRpmMax.Location = new Point(197, 72);
            txtRpmMax.Name = "txtRpmMax";
            txtRpmMax.Size = new Size(100, 23);
            txtRpmMax.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanelMaquinas, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1167, 534);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 558);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmDashboard_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanelMaquinas;
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
    }
}