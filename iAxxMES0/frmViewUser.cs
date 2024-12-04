using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iAxxMES0
{
    public partial class frmViewUser : Form
    {
        private ControleUsuario controleUsuario;

        public frmViewUser()
        {
            InitializeComponent();
            controleUsuario = new ControleUsuario();
            cbxOpcao.Items.AddRange(new string[] { "Registro da Matrícula", "Nome", "Login" });
            cbxOpcao.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmViewUser));
            cbxOpcao = new ComboBox();
            txtBusca = new TextBox();
            dgvUser = new DataGridView();
            btnBuscar = new Button();
            btnListAll = new Button();
            btnLimpar = new Button();
            lblOptBusca = new Label();
            lblBusca = new Label();
            ((ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // cbxOpcao
            // 
            cbxOpcao.FormattingEnabled = true;
            cbxOpcao.Location = new Point(25, 56);
            cbxOpcao.Name = "cbxOpcao";
            cbxOpcao.Size = new Size(139, 23);
            cbxOpcao.TabIndex = 1;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(25, 121);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite o que dejesa buscar...";
            txtBusca.Size = new Size(216, 23);
            txtBusca.TabIndex = 3;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(12, 292);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new Size(632, 218);
            dgvUser.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(46, 53, 60);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(25, 182);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(216, 32);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListAll
            // 
            btnListAll.BackColor = Color.FromArgb(46, 53, 60);
            btnListAll.FlatStyle = FlatStyle.Flat;
            btnListAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListAll.ForeColor = Color.White;
            btnListAll.Location = new Point(25, 220);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(105, 32);
            btnListAll.TabIndex = 9;
            btnListAll.Text = "Listar Todos";
            btnListAll.UseVisualStyleBackColor = false;
            btnListAll.Click += btnListAll_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(46, 53, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(136, 220);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 32);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOptBusca
            // 
            lblOptBusca.AutoSize = true;
            lblOptBusca.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOptBusca.ForeColor = Color.White;
            lblOptBusca.Location = new Point(25, 34);
            lblOptBusca.Name = "lblOptBusca";
            lblOptBusca.Size = new Size(139, 19);
            lblOptBusca.TabIndex = 11;
            lblOptBusca.Text = "Opção de busca:";
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusca.ForeColor = Color.White;
            lblBusca.Location = new Point(25, 99);
            lblBusca.Name = "lblBusca";
            lblBusca.Size = new Size(64, 19);
            lblBusca.TabIndex = 12;
            lblBusca.Text = "Busca:";
            // 
            // frmViewUser
            // 
            BackColor = Color.FromArgb(89, 105, 120);
            ClientSize = new Size(656, 522);
            Controls.Add(lblBusca);
            Controls.Add(lblOptBusca);
            Controls.Add(btnLimpar);
            Controls.Add(btnListAll);
            Controls.Add(btnBuscar);
            Controls.Add(dgvUser);
            Controls.Add(txtBusca);
            Controls.Add(cbxOpcao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(672, 561);
            Name = "frmViewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Usuários";
            ((ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cbxOpcao;
        private TextBox txtBusca;
        private Button btnBuscar;
        private Button btnListAll;
        private Button btnLimpar;
        private Label lblOptBusca;
        private Label lblBusca;
        private DataGridView dgvUser;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusca.Text))
            {
                MessageBox.Show("Por favor, digite um valor para buscar.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcao = cbxOpcao.SelectedItem.ToString();
            string valor = txtBusca.Text.Trim();

            List<Usuario> usuarios = controleUsuario.BuscarUsuarios(opcao, valor);
            AtualizarGrid(usuarios);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = controleUsuario.ListarTodosUsuarios();
            AtualizarGrid(usuarios);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            dgvUser.DataSource = null;
        }

        private void AtualizarGrid(List<Usuario> usuarios)
        {
            if (usuarios.Count > 0)
            {
                dgvUser.DataSource = usuarios;
                //dgvUser.Columns["Senha"].Visible = false; // Esconde a coluna de senha, caso exista
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUser.DataSource = null;
            }
        }
    }
}
