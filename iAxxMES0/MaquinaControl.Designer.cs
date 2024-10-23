namespace iAxxMES0
{
    partial class MaquinaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            pnlStatus = new Panel();
            lblTempoStatus = new Label();
            lblApelido = new Label();
            lblDesc = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblGrupo = new Label();
            pnlStatus.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 28);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "STATUS";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // pnlStatus
            // 
            pnlStatus.Anchor = AnchorStyles.None;
            pnlStatus.Controls.Add(lblTempoStatus);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Location = new Point(0, 23);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(160, 50);
            pnlStatus.TabIndex = 3;
            // 
            // lblTempoStatus
            // 
            lblTempoStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempoStatus.Location = new Point(0, 28);
            lblTempoStatus.Name = "lblTempoStatus";
            lblTempoStatus.Size = new Size(160, 22);
            lblTempoStatus.TabIndex = 8;
            lblTempoStatus.Text = "TempoStatus";
            lblTempoStatus.TextAlign = ContentAlignment.TopCenter;
            lblTempoStatus.Click += lblTempoStatus_Click;
            // 
            // lblApelido
            // 
            lblApelido.Dock = DockStyle.Fill;
            lblApelido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApelido.Location = new Point(0, 0);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(160, 26);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "MAQUINA";
            lblApelido.TextAlign = ContentAlignment.MiddleCenter;
            lblApelido.Click += lblApelido_Click;
            // 
            // lblDesc
            // 
            lblDesc.Dock = DockStyle.Fill;
            lblDesc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(0, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(160, 55);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Descrição";
            lblDesc.Click += lblDesc_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblApelido);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 26);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDesc);
            panel2.Location = new Point(0, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 55);
            panel2.TabIndex = 7;
            panel2.Click += panel2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblGrupo);
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 26);
            panel3.TabIndex = 7;
            // 
            // lblGrupo
            // 
            lblGrupo.Dock = DockStyle.Fill;
            lblGrupo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupo.Location = new Point(0, 0);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(160, 26);
            lblGrupo.TabIndex = 2;
            lblGrupo.Text = "Grupo";
            lblGrupo.TextAlign = ContentAlignment.MiddleLeft;
            lblGrupo.Click += lblGrupo_Click;
            // 
            // MaquinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panel3);
            Controls.Add(pnlStatus);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MaquinaControl";
            Size = new Size(160, 160);
            Click += MaquinaControl_Click;
            pnlStatus.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblStatus;
        private Panel pnlStatus;
        private Label lblApelido;
        private Label lblDesc;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblGrupo;
        private Label lblTempoStatus;
    }
}
