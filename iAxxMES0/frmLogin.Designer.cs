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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnCancelar = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblSenha = new Label();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(196, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(21, 250);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(77, 32);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 196);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(178, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(93, 141);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(178, 23);
            txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(21, 199);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(21, 144);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnCancelar;
            ClientSize = new Size(292, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblSenha);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}