namespace iAxxMES0
{
    partial class frmMaquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaquina));
            lblApelido = new Label();
            lblAlimentadoresTitle = new Label();
            lblAlimentadores = new Label();
            lblDiametroTitle = new Label();
            lblDiametro = new Label();
            lblFinuraTitle = new Label();
            lblFinura = new Label();
            lblGrupo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(12, 184);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(48, 15);
            lblApelido.TabIndex = 0;
            lblApelido.Text = "Apelido";
            // 
            // lblAlimentadoresTitle
            // 
            lblAlimentadoresTitle.AutoSize = true;
            lblAlimentadoresTitle.Location = new Point(12, 242);
            lblAlimentadoresTitle.Name = "lblAlimentadoresTitle";
            lblAlimentadoresTitle.Size = new Size(87, 15);
            lblAlimentadoresTitle.TabIndex = 1;
            lblAlimentadoresTitle.Text = "Alimentadores:";
            // 
            // lblAlimentadores
            // 
            lblAlimentadores.AutoSize = true;
            lblAlimentadores.Location = new Point(105, 242);
            lblAlimentadores.Name = "lblAlimentadores";
            lblAlimentadores.Size = new Size(13, 15);
            lblAlimentadores.TabIndex = 2;
            lblAlimentadores.Text = "0";
            // 
            // lblDiametroTitle
            // 
            lblDiametroTitle.AutoSize = true;
            lblDiametroTitle.Location = new Point(12, 267);
            lblDiametroTitle.Name = "lblDiametroTitle";
            lblDiametroTitle.Size = new Size(59, 15);
            lblDiametroTitle.TabIndex = 3;
            lblDiametroTitle.Text = "Diâmetro:";
            // 
            // lblDiametro
            // 
            lblDiametro.AutoSize = true;
            lblDiametro.Location = new Point(105, 267);
            lblDiametro.Name = "lblDiametro";
            lblDiametro.Size = new Size(13, 15);
            lblDiametro.TabIndex = 4;
            lblDiametro.Text = "0";
            // 
            // lblFinuraTitle
            // 
            lblFinuraTitle.AutoSize = true;
            lblFinuraTitle.Location = new Point(12, 291);
            lblFinuraTitle.Name = "lblFinuraTitle";
            lblFinuraTitle.Size = new Size(43, 15);
            lblFinuraTitle.TabIndex = 5;
            lblFinuraTitle.Text = "Finura:";
            // 
            // lblFinura
            // 
            lblFinura.AutoSize = true;
            lblFinura.Location = new Point(105, 291);
            lblFinura.Name = "lblFinura";
            lblFinura.Size = new Size(13, 15);
            lblFinura.TabIndex = 6;
            lblFinura.Text = "0";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 207);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(49, 15);
            lblGrupo.TabIndex = 7;
            lblGrupo.Text = "Grupo 0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 523);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrupo);
            Controls.Add(lblFinura);
            Controls.Add(lblFinuraTitle);
            Controls.Add(lblDiametro);
            Controls.Add(lblDiametroTitle);
            Controls.Add(lblAlimentadores);
            Controls.Add(lblAlimentadoresTitle);
            Controls.Add(lblApelido);
            Name = "frmMaquina";
            Text = "frmMaquina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApelido;
        private Label lblAlimentadoresTitle;
        private Label lblAlimentadores;
        private Label lblDiametroTitle;
        private Label lblDiametro;
        private Label lblFinuraTitle;
        private Label lblFinura;
        private Label lblGrupo;
        private PictureBox pictureBox1;
    }
}