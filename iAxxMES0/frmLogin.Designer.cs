namespace iAxxMES0
{
    partial class frmLogin
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
            btnCancelar = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblSenha = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(196, 128);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(21, 128);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 74);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(178, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(93, 19);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(178, 23);
            txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(21, 77);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(21, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // Login
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnCancelar;
            ClientSize = new Size(292, 167);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblSenha;
        private Label lblLogin;
    }
}