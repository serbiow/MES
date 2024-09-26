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
            panel1 = new Panel();
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
            txtNome.Location = new Point(142, 31);
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
            lblCargo.Size = new Size(62, 19);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.Location = new Point(1, 121);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(48, 19);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(1, 164);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(60, 19);
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
            btnCadastrar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(41, 340);
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
            btnCancelar.Location = new Point(165, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 32);
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
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(1, 207);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 19);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(1, 251);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmaSenha.Location = new Point(1, 292);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(131, 18);
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
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 382);
            panel1.TabIndex = 16;
            // 
            // frmCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(273, 382);
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
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Panel panel1;
    }
}