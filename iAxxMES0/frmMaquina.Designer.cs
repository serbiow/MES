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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            lblApelido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApelido.Location = new Point(12, 183);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(70, 20);
            lblApelido.TabIndex = 0;
            lblApelido.Text = "Maquina";
            // 
            // lblAlimentadoresTitle
            // 
            lblAlimentadoresTitle.AutoSize = true;
            lblAlimentadoresTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlimentadoresTitle.Location = new Point(12, 281);
            lblAlimentadoresTitle.Name = "lblAlimentadoresTitle";
            lblAlimentadoresTitle.Size = new Size(112, 20);
            lblAlimentadoresTitle.TabIndex = 1;
            lblAlimentadoresTitle.Text = "Alimentadores";
            // 
            // lblDiametroTitle
            // 
            lblDiametroTitle.AutoSize = true;
            lblDiametroTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiametroTitle.Location = new Point(12, 340);
            lblDiametroTitle.Name = "lblDiametroTitle";
            lblDiametroTitle.Size = new Size(75, 20);
            lblDiametroTitle.TabIndex = 3;
            lblDiametroTitle.Text = "Diâmetro";
            // 
            // lblFinuraTitle
            // 
            lblFinuraTitle.AutoSize = true;
            lblFinuraTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinuraTitle.Location = new Point(12, 399);
            lblFinuraTitle.Name = "lblFinuraTitle";
            lblFinuraTitle.Size = new Size(53, 20);
            lblFinuraTitle.TabIndex = 5;
            lblFinuraTitle.Text = "Finura";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 232);
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
            chartArea3.Name = "ChartArea1";
            chartStatus.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartStatus.Legends.Add(legend3);
            chartStatus.Location = new Point(217, 12);
            chartStatus.Name = "chartStatus";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartStatus.Series.Add(series3);
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
            txtAlimentadores.Location = new Point(12, 304);
            txtAlimentadores.Name = "txtAlimentadores";
            txtAlimentadores.Size = new Size(84, 23);
            txtAlimentadores.TabIndex = 17;
            // 
            // txtDiametro
            // 
            txtDiametro.Location = new Point(12, 363);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(84, 23);
            txtDiametro.TabIndex = 18;
            // 
            // txtFinura
            // 
            txtFinura.Location = new Point(12, 422);
            txtFinura.Name = "txtFinura";
            txtFinura.Size = new Size(84, 23);
            txtFinura.TabIndex = 19;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 53, 60);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(52, 503);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 30);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Salvar Alterações";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
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