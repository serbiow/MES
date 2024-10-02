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
            btnCancelar = new Button();
            mtxtMatricula = new MaskedTextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(1, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(180, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(1, 78);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(161, 19);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Nível de Permissão:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.Location = new Point(1, 121);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(84, 19);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "Matrícula:";
            // 
            // cbxNivelPermissao
            // 
            cbxNivelPermissao.FormattingEnabled = true;
            cbxNivelPermissao.Items.AddRange(new object[] { "Master", "Administrador", "Operador" });
            cbxNivelPermissao.Location = new Point(180, 78);
            cbxNivelPermissao.Name = "cbxNivelPermissao";
            cbxNivelPermissao.Size = new Size(121, 23);
            cbxNivelPermissao.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(45, 301);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 32);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(166, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtxtMatricula
            // 
            mtxtMatricula.Location = new Point(180, 121);
            mtxtMatricula.Mask = "0000000000";
            mtxtMatricula.Name = "mtxtMatricula";
            mtxtMatricula.Size = new Size(121, 23);
            mtxtMatricula.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(3, 163);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 19);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(3, 207);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmaSenha.Location = new Point(3, 251);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(131, 18);
            lblConfirmaSenha.TabIndex = 15;
            lblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(180, 163);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(121, 23);
            txtLogin.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(180, 207);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(121, 23);
            txtSenha.TabIndex = 12;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(180, 250);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(121, 23);
            txtConfirmaSenha.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(mtxtMatricula);
            panel1.Controls.Add(lblConfirmaSenha);
            panel1.Controls.Add(cbxNivelPermissao);
            panel1.Controls.Add(btnCancelar);
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
            panel1.Size = new Size(313, 353);
            panel1.TabIndex = 16;
            // 
            // frmCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(313, 353);
            Controls.Add(lblCPF);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private Label lblCPF;
        private ComboBox cbxNivelPermissao;
        private Button btnCadastrar;
        private Button btnCancelar;
        private MaskedTextBox mtxtMatricula;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
        private Panel panel1;
    }
}