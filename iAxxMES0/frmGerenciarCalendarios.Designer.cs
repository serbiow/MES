namespace iAxxMES0
{
    partial class frmGerenciarCalendarios
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
            panel3 = new Panel();
            btnListAll = new Button();
            dgvCalendarios = new DataGridView();
            label2 = new Label();
            txtGrupo = new TextBox();
            panel1 = new Panel();
            btnEditar = new Button();
            lblDescCalemdario = new Label();
            btnBuscar = new Button();
            btnLimpar = new Button();
            txtDescCalendario = new TextBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            lblNomeCalendario = new Label();
            txtNomeCalendario = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            btnSalvar = new Button();
            clbMaquinas = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalendarios).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnListAll);
            panel3.Controls.Add(dgvCalendarios);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 565);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 298);
            panel3.TabIndex = 1;
            // 
            // btnListAll
            // 
            btnListAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(829, 11);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 31;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            // 
            // dgvCalendarios
            // 
            dgvCalendarios.AllowUserToAddRows = false;
            dgvCalendarios.AllowUserToDeleteRows = false;
            dgvCalendarios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCalendarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalendarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalendarios.Location = new Point(9, 48);
            dgvCalendarios.Name = "dgvCalendarios";
            dgvCalendarios.ReadOnly = true;
            dgvCalendarios.Size = new Size(925, 241);
            dgvCalendarios.TabIndex = 30;
            dgvCalendarios.SelectionChanged += dgvCalendarios_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 174);
            label2.Name = "label2";
            label2.Size = new Size(180, 19);
            label2.TabIndex = 28;
            label2.Text = "Manipular Calendários";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(9, 196);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Nome do Grupo";
            txtGrupo.Size = new Size(216, 23);
            txtGrupo.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblDescCalemdario);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(txtDescCalendario);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(lblNomeCalendario);
            panel1.Controls.Add(txtNomeCalendario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 550);
            panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(120, 430);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 32);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblDescCalemdario
            // 
            lblDescCalemdario.AutoSize = true;
            lblDescCalemdario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescCalemdario.ForeColor = Color.Black;
            lblDescCalemdario.Location = new Point(9, 240);
            lblDescCalemdario.Name = "lblDescCalemdario";
            lblDescCalemdario.Size = new Size(166, 19);
            lblDescCalemdario.TabIndex = 25;
            lblDescCalemdario.Text = "Descrição do grupo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(6, 54);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(216, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(231, 430);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtDescCalendario
            // 
            txtDescCalendario.Location = new Point(9, 262);
            txtDescCalendario.Multiline = true;
            txtDescCalendario.Name = "txtDescCalendario";
            txtDescCalendario.PlaceholderText = "Descrição do Calendário";
            txtDescCalendario.Size = new Size(438, 162);
            txtDescCalendario.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(342, 430);
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
            btnAdicionar.Location = new Point(9, 430);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // lblNomeCalendario
            // 
            lblNomeCalendario.AutoSize = true;
            lblNomeCalendario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCalendario.ForeColor = Color.Black;
            lblNomeCalendario.Location = new Point(6, 3);
            lblNomeCalendario.Name = "lblNomeCalendario";
            lblNomeCalendario.Size = new Size(151, 19);
            lblNomeCalendario.TabIndex = 20;
            lblNomeCalendario.Text = "Buscar Calendário";
            // 
            // txtNomeCalendario
            // 
            txtNomeCalendario.Location = new Point(6, 25);
            txtNomeCalendario.Name = "txtNomeCalendario";
            txtNomeCalendario.PlaceholderText = "Nome do Calendário";
            txtNomeCalendario.Size = new Size(216, 23);
            txtNomeCalendario.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 473F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.MinimumSize = new Size(0, 500);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(943, 556);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(clbMaquinas);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(476, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 550);
            panel2.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(353, 430);
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
            clbMaquinas.Location = new Point(1, 6);
            clbMaquinas.MultiColumn = true;
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(457, 418);
            clbMaquinas.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(940, 845);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(949, 866);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // frmGerenciarCalendarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(949, 866);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(965, 905);
            Name = "frmGerenciarCalendarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Calendários";
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalendarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private TextBox txtGrupo;
        private Panel panel1;
        private Button btnEditar;
        private Label lblDescCalemdario;
        private Button btnBuscar;
        private Button btnLimpar;
        private TextBox txtDescCalendario;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Label lblNomeCalendario;
        private TextBox txtNomeCalendario;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button btnSalvar;
        private CheckedListBox clbMaquinas;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCalendarios;
        private Button btnListAll;
    }
}