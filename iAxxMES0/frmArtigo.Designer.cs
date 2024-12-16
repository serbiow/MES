namespace iAxxMES0
{
    partial class frmArtigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtigo));
            menuStrip1 = new MenuStrip();
            supervisaoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarGruposToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            calendárioDeDisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            visualizarCalendárioToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCalendáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeIndisponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(197, 202, 208);
            menuStrip1.Items.AddRange(new ToolStripItem[] { supervisaoToolStripMenuItem, gerenciarGruposToolStripMenuItem, usuáriosToolStripMenuItem, calendárioDeDisponibilidadeToolStripMenuItem, relatórioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // supervisaoToolStripMenuItem
            // 
            supervisaoToolStripMenuItem.Name = "supervisaoToolStripMenuItem";
            supervisaoToolStripMenuItem.Size = new Size(76, 20);
            supervisaoToolStripMenuItem.Text = "Supervisão";
            supervisaoToolStripMenuItem.Click += supervisaoToolStripMenuItem_Click;
            // 
            // gerenciarGruposToolStripMenuItem
            // 
            gerenciarGruposToolStripMenuItem.Name = "gerenciarGruposToolStripMenuItem";
            gerenciarGruposToolStripMenuItem.Size = new Size(110, 20);
            gerenciarGruposToolStripMenuItem.Text = "Gerenciar Grupos";
            gerenciarGruposToolStripMenuItem.Click += gerenciarGruposToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, cadastrarToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // calendárioDeDisponibilidadeToolStripMenuItem
            // 
            calendárioDeDisponibilidadeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarCalendárioToolStripMenuItem, gerenciarCalendáriosToolStripMenuItem, cadastroDeIndisponibilidadeToolStripMenuItem });
            calendárioDeDisponibilidadeToolStripMenuItem.Name = "calendárioDeDisponibilidadeToolStripMenuItem";
            calendárioDeDisponibilidadeToolStripMenuItem.Size = new Size(177, 20);
            calendárioDeDisponibilidadeToolStripMenuItem.Text = "Calendário de Disponibilidade";
            // 
            // visualizarCalendárioToolStripMenuItem
            // 
            visualizarCalendárioToolStripMenuItem.Name = "visualizarCalendárioToolStripMenuItem";
            visualizarCalendárioToolStripMenuItem.Size = new Size(231, 22);
            visualizarCalendárioToolStripMenuItem.Text = "Visualizar Calendário";
            visualizarCalendárioToolStripMenuItem.Click += visualizarCalendárioToolStripMenuItem_Click;
            // 
            // gerenciarCalendáriosToolStripMenuItem
            // 
            gerenciarCalendáriosToolStripMenuItem.Name = "gerenciarCalendáriosToolStripMenuItem";
            gerenciarCalendáriosToolStripMenuItem.Size = new Size(231, 22);
            gerenciarCalendáriosToolStripMenuItem.Text = "Gerenciar Calendários";
            gerenciarCalendáriosToolStripMenuItem.Click += gerenciarCalendáriosToolStripMenuItem_Click;
            // 
            // cadastroDeIndisponibilidadeToolStripMenuItem
            // 
            cadastroDeIndisponibilidadeToolStripMenuItem.Name = "cadastroDeIndisponibilidadeToolStripMenuItem";
            cadastroDeIndisponibilidadeToolStripMenuItem.Size = new Size(231, 22);
            cadastroDeIndisponibilidadeToolStripMenuItem.Text = "Cadastro de Indisponibilidade";
            cadastroDeIndisponibilidadeToolStripMenuItem.Click += cadastroDeIndisponibilidadeToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.FromArgb(197, 202, 208);
            sairToolStripMenuItem.ForeColor = Color.Black;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmArtigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 202, 208);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmArtigo";
            Text = "frmArtigo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem supervisaoToolStripMenuItem;
        private ToolStripMenuItem gerenciarGruposToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem calendárioDeDisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem visualizarCalendárioToolStripMenuItem;
        private ToolStripMenuItem gerenciarCalendáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeIndisponibilidadeToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}