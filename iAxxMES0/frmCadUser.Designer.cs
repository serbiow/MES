namespace iAxxMES0
{
    partial class frmCadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUser));
            lblNome = new Label();
            txtNome = new TextBox();
            lblCargo = new Label();
            lblCPF = new Label();
            cbxNivelPermissao = new ComboBox();
            btnCadastrar = new Button();
            mtxtMatricula = new MaskedTextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            panel1 = new Panel();
            btnLimpar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            lblCodigo = new Label();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(30, 145);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(207, 145);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.ForeColor = Color.White;
            lblCargo.Location = new Point(30, 189);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(161, 19);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Nível de Permissão:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.ForeColor = Color.White;
            lblCPF.Location = new Point(30, 232);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(84, 19);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "Matrícula:";
            // 
            // cbxNivelPermissao
            // 
            cbxNivelPermissao.FormattingEnabled = true;
            cbxNivelPermissao.Items.AddRange(new object[] { "Master", "Administrador", "Operador" });
            cbxNivelPermissao.Location = new Point(207, 189);
            cbxNivelPermissao.Name = "cbxNivelPermissao";
            cbxNivelPermissao.Size = new Size(121, 23);
            cbxNivelPermissao.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(46, 53, 60);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(51, 436);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 32);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // mtxtMatricula
            // 
            mtxtMatricula.Location = new Point(207, 232);
            mtxtMatricula.Mask = "0000000000";
            mtxtMatricula.Name = "mtxtMatricula";
            mtxtMatricula.Size = new Size(121, 23);
            mtxtMatricula.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(30, 274);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 19);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(30, 318);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmaSenha.ForeColor = Color.White;
            lblConfirmaSenha.Location = new Point(30, 362);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(131, 18);
            lblConfirmaSenha.TabIndex = 15;
            lblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(207, 274);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(254, 23);
            txtLogin.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(207, 318);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(207, 361);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(254, 23);
            txtConfirmaSenha.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 105, 120);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(lblCPF);
            panel1.Controls.Add(mtxtMatricula);
            panel1.Controls.Add(lblCargo);
            panel1.Controls.Add(lblConfirmaSenha);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(cbxNivelPermissao);
            panel1.Controls.Add(txtConfirmaSenha);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 528);
            panel1.TabIndex = 16;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(238, 436);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(77, 32);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(46, 53, 60);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(145, 436);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(77, 32);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(46, 53, 60);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(330, 436);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(77, 32);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(30, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(69, 19);
            lblCodigo.TabIndex = 19;
            lblCodigo.Text = "User Id:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(30, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(105, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // frmCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(487, 528);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private Label lblCPF;
        private ComboBox cbxNivelPermissao;
        private Button btnCadastrar;
        private MaskedTextBox mtxtMatricula;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
        private Panel panel1;
        private Button btnAlterar;
        private Button btnExcluir;
        private Label lblCodigo;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private Button btnLimpar;
    }
}