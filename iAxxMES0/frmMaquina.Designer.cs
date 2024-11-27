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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblApelido = new Label();
            lblAlimentadoresTitle = new Label();
            lblDiametroTitle = new Label();
            lblFinuraTitle = new Label();
            lblGrupo = new Label();
            pictureBox1 = new PictureBox();
            chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtApelido = new TextBox();
            txtAlimentadores = new TextBox();
            txtDiametro = new TextBox();
            txtFinura = new TextBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStatus).BeginInit();
            SuspendLayout();
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(12, 184);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(54, 15);
            lblApelido.TabIndex = 0;
            lblApelido.Text = "Maquina";
            // 
            // lblAlimentadoresTitle
            // 
            lblAlimentadoresTitle.AutoSize = true;
            lblAlimentadoresTitle.Location = new Point(12, 308);
            lblAlimentadoresTitle.Name = "lblAlimentadoresTitle";
            lblAlimentadoresTitle.Size = new Size(84, 15);
            lblAlimentadoresTitle.TabIndex = 1;
            lblAlimentadoresTitle.Text = "Alimentadores";
            // 
            // lblDiametroTitle
            // 
            lblDiametroTitle.AutoSize = true;
            lblDiametroTitle.Location = new Point(12, 367);
            lblDiametroTitle.Name = "lblDiametroTitle";
            lblDiametroTitle.Size = new Size(56, 15);
            lblDiametroTitle.TabIndex = 3;
            lblDiametroTitle.Text = "Diâmetro";
            // 
            // lblFinuraTitle
            // 
            lblFinuraTitle.AutoSize = true;
            lblFinuraTitle.Location = new Point(12, 426);
            lblFinuraTitle.Name = "lblFinuraTitle";
            lblFinuraTitle.Size = new Size(40, 15);
            lblFinuraTitle.TabIndex = 5;
            lblFinuraTitle.Text = "Finura";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 258);
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
            // chartStatus
            // 
            chartStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStatus.Legends.Add(legend1);
            chartStatus.Location = new Point(217, 12);
            chartStatus.Name = "chartStatus";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStatus.Series.Add(series1);
            chartStatus.Size = new Size(669, 580);
            chartStatus.TabIndex = 15;
            chartStatus.Text = "chart1";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(12, 206);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(138, 23);
            txtApelido.TabIndex = 16;
            // 
            // txtAlimentadores
            // 
            txtAlimentadores.Location = new Point(12, 326);
            txtAlimentadores.Name = "txtAlimentadores";
            txtAlimentadores.Size = new Size(84, 23);
            txtAlimentadores.TabIndex = 17;
            // 
            // txtDiametro
            // 
            txtDiametro.Location = new Point(12, 385);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(84, 23);
            txtDiametro.TabIndex = 18;
            // 
            // txtFinura
            // 
            txtFinura.Location = new Point(12, 444);
            txtFinura.Name = "txtFinura";
            txtFinura.Size = new Size(84, 23);
            txtFinura.TabIndex = 19;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(50, 523);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Salvar Alterações";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 604);
            Controls.Add(btnEditar);
            Controls.Add(txtFinura);
            Controls.Add(txtDiametro);
            Controls.Add(txtAlimentadores);
            Controls.Add(txtApelido);
            Controls.Add(chartStatus);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrupo);
            Controls.Add(lblFinuraTitle);
            Controls.Add(lblDiametroTitle);
            Controls.Add(lblAlimentadoresTitle);
            Controls.Add(lblApelido);
            Name = "frmMaquina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApelido;
        private Label lblAlimentadoresTitle;
        private Label lblDiametroTitle;
        private Label lblFinuraTitle;
        private Label lblGrupo;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private TextBox txtApelido;
        private TextBox txtAlimentadores;
        private TextBox txtDiametro;
        private TextBox txtFinura;
        private Button btnEditar;
    }
}