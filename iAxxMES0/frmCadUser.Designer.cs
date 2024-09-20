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
            lblNome = new Label();
            txtNome = new TextBox();
            lblCargo = new Label();
            lblCPF = new Label();
            lblTurno = new Label();
            cbxCargo = new ComboBox();
            cbxTurno = new ComboBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            mtxtCPF = new MaskedTextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(28, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(28, 78);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(28, 121);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(28, 164);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(41, 15);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // cbxCargo
            // 
            cbxCargo.FormattingEnabled = true;
            cbxCargo.Items.AddRange(new object[] { "Master", "Administrador", "Operador" });
            cbxCargo.Location = new Point(142, 75);
            cbxCargo.Name = "cbxCargo";
            cbxCargo.Size = new Size(121, 23);
            cbxCargo.TabIndex = 8;
            // 
            // cbxTurno
            // 
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite" });
            cbxTurno.Location = new Point(142, 161);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(121, 23);
            cbxTurno.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(44, 351);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(168, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtxtCPF
            // 
            mtxtCPF.Location = new Point(142, 118);
            mtxtCPF.Mask = "000,000,000-00";
            mtxtCPF.Name = "mtxtCPF";
            mtxtCPF.Size = new Size(121, 23);
            mtxtCPF.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(28, 207);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(28, 251);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(28, 294);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(99, 15);
            lblConfirmaSenha.TabIndex = 15;
            lblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(142, 204);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(121, 23);
            txtLogin.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(142, 248);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(121, 23);
            txtSenha.TabIndex = 12;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(142, 291);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(121, 23);
            txtConfirmaSenha.TabIndex = 13;
            // 
            // frmCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 386);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblConfirmaSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(mtxtCPF);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxTurno);
            Controls.Add(cbxCargo);
            Controls.Add(lblTurno);
            Controls.Add(lblCPF);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private Label lblCPF;
        private Label lblTurno;
        private ComboBox cbxCargo;
        private ComboBox cbxTurno;
        private Button btnCadastrar;
        private Button btnCancelar;
        private MaskedTextBox mtxtCPF;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
    }
}