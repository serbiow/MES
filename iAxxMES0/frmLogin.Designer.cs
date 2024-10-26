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
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblSenha = new Label();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(169, 177, 185);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(280, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 33);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(139, 380);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(139, 322);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(248, 23);
            txtLogin.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(139, 358);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(139, 300);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iAxxLogo;
            pictureBox1.Location = new Point(139, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 505);
            panel1.TabIndex = 7;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(169, 177, 185);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(164, 425);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(77, 33);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            CancelButton = btnCancelar;
            ClientSize = new Size(563, 529);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblSenha;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnEntrar;
    }
}