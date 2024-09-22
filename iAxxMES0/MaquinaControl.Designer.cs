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
            lblApelidoTitle = new Label();
            lblRPMTitle = new Label();
            lblStatus = new Label();
            pnlStatus = new Panel();
            lblApelido = new Label();
            lblRPM = new Label();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblApelidoTitle
            // 
            lblApelidoTitle.AutoSize = true;
            lblApelidoTitle.Location = new Point(3, 46);
            lblApelidoTitle.Name = "lblApelidoTitle";
            lblApelidoTitle.Size = new Size(51, 15);
            lblApelidoTitle.TabIndex = 0;
            lblApelidoTitle.Text = "Apelido:";
            // 
            // lblRPMTitle
            // 
            lblRPMTitle.AutoSize = true;
            lblRPMTitle.Location = new Point(3, 86);
            lblRPMTitle.Name = "lblRPMTitle";
            lblRPMTitle.Size = new Size(35, 15);
            lblRPMTitle.TabIndex = 1;
            lblRPMTitle.Text = "RPM:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(56, 5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "status";
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Location = new Point(0, 0);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(150, 25);
            pnlStatus.TabIndex = 3;
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(60, 46);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(48, 15);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "Apelido";
            // 
            // lblRPM
            // 
            lblRPM.AutoSize = true;
            lblRPM.Location = new Point(44, 86);
            lblRPM.Name = "lblRPM";
            lblRPM.Size = new Size(32, 15);
            lblRPM.TabIndex = 5;
            lblRPM.Text = "RPM";
            // 
            // MaquinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRPM);
            Controls.Add(lblApelido);
            Controls.Add(pnlStatus);
            Controls.Add(lblRPMTitle);
            Controls.Add(lblApelidoTitle);
            Name = "MaquinaControl";
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApelidoTitle;
        private Label lblRPMTitle;
        private Label lblStatus;
        private Panel pnlStatus;
        private Label lblApelido;
        private Label lblRPM;
    }
}
