namespace iAxxMES0
{
    partial class CadUser
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
            txtCPF = new TextBox();
            lblTurno = new Label();
            cbxCargo = new ComboBox();
            cbxTurno = new ComboBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(37, 94);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(115, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(37, 138);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(37, 181);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(115, 178);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(121, 23);
            txtCPF.TabIndex = 5;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(37, 224);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(41, 15);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // cbxCargo
            // 
            cbxCargo.FormattingEnabled = true;
            cbxCargo.Location = new Point(115, 135);
            cbxCargo.Name = "cbxCargo";
            cbxCargo.Size = new Size(121, 23);
            cbxCargo.TabIndex = 8;
            // 
            // cbxTurno
            // 
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Items.AddRange(new object[] { "...", "Manhã", "Tarde", "Noite" });
            cbxTurno.Location = new Point(115, 221);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(121, 23);
            cbxTurno.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(37, 281);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(161, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxTurno);
            Controls.Add(cbxCargo);
            Controls.Add(lblTurno);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "CadUser";
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
        private TextBox txtCPF;
        private Label lblTurno;
        private ComboBox cbxCargo;
        private ComboBox cbxTurno;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}