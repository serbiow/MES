namespace iAxxMES0
{
    partial class frmArtigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtigo));
            menuStrip1 = new MenuStrip();
            supervisaoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarGruposToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            calendárioDeDisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            visualizarCalendárioToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCalendáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeIndisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnListAll = new Button();
            dgvArtigos = new DataGridView();
            lblNomeArtigo = new Label();
            txtNomeArtigo = new TextBox();
            btnBuscar = new Button();
            btnSalvar = new Button();
            dtpTimeFinal = new DateTimePicker();
            dtpTimeInicial = new DateTimePicker();
            label5 = new Label();
            dtpDataFinal = new DateTimePicker();
            label4 = new Label();
            dtpDataInicial = new DateTimePicker();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            clbMaquinas = new CheckedListBox();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(197, 202, 208);
            menuStrip1.Items.AddRange(new ToolStripItem[] { supervisaoToolStripMenuItem, gerenciarGruposToolStripMenuItem, usuáriosToolStripMenuItem, calendárioDeDisponibilidadeToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(647, 24);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // supervisaoToolStripMenuItem
            // 
            supervisaoToolStripMenuItem.Name = "supervisaoToolStripMenuItem";
            supervisaoToolStripMenuItem.Size = new Size(76, 20);
            supervisaoToolStripMenuItem.Text = "Supervisão";
            supervisaoToolStripMenuItem.Click += supervisaoToolStripMenuItem_Click;
            // 
            // gerenciarGruposToolStripMenuItem
            // 
            gerenciarGruposToolStripMenuItem.Name = "gerenciarGruposToolStripMenuItem";
            gerenciarGruposToolStripMenuItem.Size = new Size(110, 20);
            gerenciarGruposToolStripMenuItem.Text = "Gerenciar Grupos";
            gerenciarGruposToolStripMenuItem.Click += gerenciarGruposToolStripMenuItem_Click;
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
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(125, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
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
            visualizarCalendárioToolStripMenuItem.Click += visualizarCalendárioToolStripMenuItem_Click;
            // 
            // gerenciarCalendáriosToolStripMenuItem
            // 
            gerenciarCalendáriosToolStripMenuItem.Name = "gerenciarCalendáriosToolStripMenuItem";
            gerenciarCalendáriosToolStripMenuItem.Size = new Size(231, 22);
            gerenciarCalendáriosToolStripMenuItem.Text = "Gerenciar Calendários";
            gerenciarCalendáriosToolStripMenuItem.Click += gerenciarCalendáriosToolStripMenuItem_Click;
            // 
            // cadastroDeIndisponibilidadeToolStripMenuItem
            // 
            cadastroDeIndisponibilidadeToolStripMenuItem.Name = "cadastroDeIndisponibilidadeToolStripMenuItem";
            cadastroDeIndisponibilidadeToolStripMenuItem.Size = new Size(231, 22);
            cadastroDeIndisponibilidadeToolStripMenuItem.Text = "Cadastro de Indisponibilidade";
            cadastroDeIndisponibilidadeToolStripMenuItem.Click += cadastroDeIndisponibilidadeToolStripMenuItem_Click;
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
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(123, 442);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 37;
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
            dgvArtigos.Location = new Point(12, 480);
            dgvArtigos.Name = "dgvArtigos";
            dgvArtigos.ReadOnly = true;
            dgvArtigos.Size = new Size(623, 220);
            dgvArtigos.TabIndex = 36;
            dgvArtigos.SelectionChanged += dgvArtigos_SelectionChanged;
            // 
            // lblNomeArtigo
            // 
            lblNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNomeArtigo.AutoSize = true;
            lblNomeArtigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeArtigo.ForeColor = Color.Black;
            lblNomeArtigo.Location = new Point(12, 391);
            lblNomeArtigo.Name = "lblNomeArtigo";
            lblNomeArtigo.Size = new Size(113, 19);
            lblNomeArtigo.TabIndex = 35;
            lblNomeArtigo.Text = "Buscar Artigo";
            // 
            // txtNomeArtigo
            // 
            txtNomeArtigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNomeArtigo.Location = new Point(12, 413);
            txtNomeArtigo.Name = "txtNomeArtigo";
            txtNomeArtigo.PlaceholderText = "Nome do Artigo";
            txtNomeArtigo.Size = new Size(216, 23);
            txtNomeArtigo.TabIndex = 33;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(12, 442);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 32);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(9, 192);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Associar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtpTimeFinal
            // 
            dtpTimeFinal.Format = DateTimePickerFormat.Time;
            dtpTimeFinal.Location = new Point(180, 53);
            dtpTimeFinal.Name = "dtpTimeFinal";
            dtpTimeFinal.ShowUpDown = true;
            dtpTimeFinal.Size = new Size(141, 23);
            dtpTimeFinal.TabIndex = 45;
            dtpTimeFinal.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTimeInicial
            // 
            dtpTimeInicial.Format = DateTimePickerFormat.Time;
            dtpTimeInicial.Location = new Point(12, 53);
            dtpTimeInicial.Name = "dtpTimeInicial";
            dtpTimeInicial.ShowUpDown = true;
            dtpTimeInicial.Size = new Size(149, 23);
            dtpTimeInicial.TabIndex = 44;
            dtpTimeInicial.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(180, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 43;
            label5.Text = "Data e Hora Final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(180, 24);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(141, 23);
            dtpDataFinal.TabIndex = 42;
            dtpDataFinal.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 41;
            label4.Text = "Data e Hora Inicial";
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(12, 24);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(149, 23);
            dtpDataInicial.TabIndex = 40;
            dtpDataInicial.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 33);
            panel1.TabIndex = 46;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(623, 33);
            label1.TabIndex = 30;
            label1.Text = "Associação de Artigos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 47;
            label2.Text = "Máquinas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(clbMaquinas);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSalvar);
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 227);
            panel2.TabIndex = 48;
            // 
            // clbMaquinas
            // 
            clbMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbMaquinas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbMaquinas.FormattingEnabled = true;
            clbMaquinas.Location = new Point(9, 24);
            clbMaquinas.MultiColumn = true;
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(623, 166);
            clbMaquinas.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dtpDataInicial);
            panel3.Controls.Add(dtpTimeFinal);
            panel3.Controls.Add(dtpDataFinal);
            panel3.Controls.Add(dtpTimeInicial);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(647, 322);
            panel3.TabIndex = 49;
            // 
            // frmArtigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(647, 712);
            Controls.Add(panel1);
            Controls.Add(btnListAll);
            Controls.Add(dgvArtigos);
            Controls.Add(lblNomeArtigo);
            Controls.Add(txtNomeArtigo);
            Controls.Add(btnBuscar);
            Controls.Add(menuStrip1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(663, 751);
            Name = "frmArtigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Associação de Artigos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtigos).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem supervisaoToolStripMenuItem;
        private ToolStripMenuItem gerenciarGruposToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem calendárioDeDisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem visualizarCalendárioToolStripMenuItem;
        private ToolStripMenuItem gerenciarCalendáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeIndisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnListAll;
        private DataGridView dgvArtigos;
        private Label lblNomeArtigo;
        private TextBox txtNomeArtigo;
        private Button btnBuscar;
        private Button btnSalvar;
        private DateTimePicker dtpTimeFinal;
        private DateTimePicker dtpTimeInicial;
        private Label label5;
        private DateTimePicker dtpDataFinal;
        private Label label4;
        private DateTimePicker dtpDataInicial;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private CheckedListBox clbMaquinas;
        private Panel panel3;
    }
}