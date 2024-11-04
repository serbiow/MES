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
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // lblNomeGrupo
            // 
            lblNomeGrupo.AutoSize = true;
            lblNomeGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGrupo.ForeColor = Color.White;
            lblNomeGrupo.Location = new Point(12, 9);
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
            btnLimpar.Location = new Point(12, 316);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 18;
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
            btnListAll.Location = new Point(698, 332);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 17;
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
            btnBuscar.Location = new Point(12, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(216, 32);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dgvGrupos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(12, 370);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.Size = new Size(791, 244);
            dgvGrupos.TabIndex = 15;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(12, 31);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(216, 23);
            txtGrupo.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(123, 316);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 32);
            btnExcluir.TabIndex = 22;
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
            btnAdicionar.Location = new Point(12, 278);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 32);
            btnAdicionar.TabIndex = 23;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDescGrupo
            // 
            txtDescGrupo.Location = new Point(12, 139);
            txtDescGrupo.Multiline = true;
            txtDescGrupo.Name = "txtDescGrupo";
            txtDescGrupo.Size = new Size(216, 106);
            txtDescGrupo.TabIndex = 24;
            // 
            // lblDescGrupo
            // 
            lblDescGrupo.AutoSize = true;
            lblDescGrupo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescGrupo.ForeColor = Color.White;
            lblDescGrupo.Location = new Point(12, 117);
            lblDescGrupo.Name = "lblDescGrupo";
            lblDescGrupo.Size = new Size(166, 19);
            lblDescGrupo.TabIndex = 25;
            lblDescGrupo.Text = "Descrição do grupo:";
            // 
            // clbMaquinas
            // 
            clbMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clbMaquinas.FormattingEnabled = true;
            clbMaquinas.Location = new Point(427, 9);
            clbMaquinas.Name = "clbMaquinas";
            clbMaquinas.Size = new Size(376, 202);
            clbMaquinas.TabIndex = 26;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(123, 278);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 32);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(46, 53, 60);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(698, 217);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmGerenciarGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 105, 120);
            ClientSize = new Size(815, 626);
            Controls.Add(btnSalvar);
            Controls.Add(clbMaquinas);
            Controls.Add(lblDescGrupo);
            Controls.Add(txtDescGrupo);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblNomeGrupo);
            Controls.Add(btnLimpar);
            Controls.Add(btnListAll);
            Controls.Add(btnBuscar);
            Controls.Add(dgvGrupos);
            Controls.Add(txtGrupo);
            Name = "frmGerenciarGrupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Grupos";
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
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
    }
}