using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iAxxMES0
{
    public partial class frmCalendario : Form
    {
        private ControleDisponibilidade controleDisponibilidade;
        private int anoAtual;
        private int mesAtual;

        public frmCalendario()
        {
            InitializeComponent();
            controleDisponibilidade = new ControleDisponibilidade();
            anoAtual = DateTime.Today.Year; // Ano atual
            mesAtual = DateTime.Today.Month; // Mês atual
            InicializarCalendario();
            CarregarIndisponibilidades();
        }

        // Inicializa o calendário personalizado (DataGridView)
        private void InicializarCalendario()
        {
            dgvCalendario.ColumnCount = 7; // 7 colunas para os dias da semana

            // Define os cabeçalhos das colunas
            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                dgvCalendario.Columns[i].HeaderText = diasSemana[i];
                //dgvCalendario.Columns[i].Width = 50; // Largura de cada coluna
                //dgvCalendario.RowTemplate.Height = 50; // Altura de cada linha
            }

            dgvCalendario.RowHeadersVisible = false; // Oculta a coluna de cabeçalho das linhas
            dgvCalendario.AllowUserToResizeColumns = false;
            dgvCalendario.AllowUserToResizeRows = false;
            dgvCalendario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCalendario.ReadOnly = true;

            // Configura o evento de clique no calendário
            dgvCalendario.CellClick += dgvCalendario_CellClick;
        }

        // Método auxiliar para obter o nome do mês
        private string ObterNomeDoMes(int mes)
        {
            var culturaBrasileira = new System.Globalization.CultureInfo("pt-BR");
            return culturaBrasileira.DateTimeFormat.GetMonthName(mes);
        }

        // Verifica se há indisponibilidade para uma data específica
        private bool TemIndisponibilidade(DateTime data, List<Indisponibilidade> indisponibilidades)
        {
            return indisponibilidades.Any(ind =>
                (ind.Tipo == "Específico" && ind.DataEspecifica.HasValue && ind.DataEspecifica.Value.Date == data.Date) ||
                (ind.Tipo == "Semanal" && DiaSemanaParaDayOfWeek(ind.DiaSemana) == data.DayOfWeek)
            );
        }

        // Atualiza o calendário para o mês atual
        private void AtualizarCalendario()
        {
            // Atualiza o texto do Label para exibir o mês e ano atuais
            lblMesAno.Text = $"{ObterNomeDoMes(mesAtual)} de {anoAtual}";

            dgvCalendario.Rows.Clear(); // Limpa as linhas do calendário

            DateTime primeiroDiaDoMes = new DateTime(anoAtual, mesAtual, 1);
            int diasNoMes = DateTime.DaysInMonth(anoAtual, mesAtual);

            // Busca as indisponibilidades
            List<Indisponibilidade> indisponibilidades = controleDisponibilidade.BuscarTodasIndisponibilidades();

            // Adiciona as células ao calendário
            int diaAtual = 1;
            int diaDaSemana = (int)primeiroDiaDoMes.DayOfWeek;
            for (int semana = 0; diaAtual <= diasNoMes; semana++)
            {
                dgvCalendario.Rows.Add();
                dgvCalendario.Rows[semana].Height = 60;
                for (int dia = 0; dia < 7; dia++)
                {
                    if (semana == 0 && dia < diaDaSemana || diaAtual > diasNoMes)
                    {
                        dgvCalendario.Rows[semana].Cells[dia].Value = ""; // Célula vazia
                    }
                    else
                    {
                        DateTime dataAtual = new DateTime(anoAtual, mesAtual, diaAtual);
                        dgvCalendario.Rows[semana].Cells[dia].Value = diaAtual.ToString(); // Número do dia
                        dgvCalendario.Rows[semana].Cells[dia].Tag = dataAtual; // Associa a data à célula

                        // Verifica se há indisponibilidade para esse dia
                        if (TemIndisponibilidade(dataAtual, indisponibilidades))
                        {
                            // Aplica estilo à célula com indisponibilidade
                            dgvCalendario.Rows[semana].Cells[dia].Style.BackColor = Color.LightGray; // Cor de fundo
                            dgvCalendario.Rows[semana].Cells[dia].Style.ForeColor = Color.Black;      // Cor do texto
                            dgvCalendario.Rows[semana].Cells[dia].Style.Font = new Font(dgvCalendario.Font, FontStyle.Bold); // Negrito
                        }

                        diaAtual++;
                    }
                }
            }
        }

        private void CarregarIndisponibilidades()
        {
            try
            {
                // Busca as indisponibilidades
                List<Indisponibilidade> indisponibilidades = controleDisponibilidade.BuscarTodasIndisponibilidades();

                // Atualiza o calendário personalizado e o DataGridView de indisponibilidades
                AtualizarCalendario();
                AtualizarGrid(indisponibilidades);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar indisponibilidades: {ex.Message}");
            }
        }

        // Evento para quando o usuário clica em um dia no calendário
        private void dgvCalendario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var celula = dgvCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (celula.Tag is DateTime dataSelecionada)
                {
                    FiltrarIndisponibilidadesPorData(dataSelecionada);
                }
            }
        }

        private void AtualizarGrid(List<Indisponibilidade> indisponibilidades)
        {
            // Configura as colunas do DataGridView (caso não estejam configuradas)
            if (dataGridViewIndisponibilidades.Columns.Count == 0)
            {
                dataGridViewIndisponibilidades.Columns.Add("Id", "Id");
                dataGridViewIndisponibilidades.Columns.Add("Data", "Data");
                dataGridViewIndisponibilidades.Columns.Add("DiaSemana", "Dia da Semana");
                dataGridViewIndisponibilidades.Columns.Add("HorarioInicio", "Início");
                dataGridViewIndisponibilidades.Columns.Add("HorarioFim", "Fim");
                dataGridViewIndisponibilidades.Columns.Add("Motivo", "Motivo");

                dataGridViewIndisponibilidades.Columns["Id"].Visible = false;
            }

            // Limpa os dados do DataGridView
            dataGridViewIndisponibilidades.Rows.Clear();

            // Preenche com os dados
            foreach (var indisponibilidade in indisponibilidades)
            {
                string dataOuDia = indisponibilidade.Tipo == "Específico"
                    ? indisponibilidade.DataEspecifica?.ToString("dd/MM/yyyy")
                    : indisponibilidade.DiaSemana;

                dataGridViewIndisponibilidades.Rows.Add(
                    indisponibilidade.Id,
                    dataOuDia,
                    indisponibilidade.DiaSemana,
                    indisponibilidade.HorarioInicio.ToString(@"hh\:mm"),
                    indisponibilidade.HorarioFim.ToString(@"hh\:mm"),
                    indisponibilidade.Motivo
                );
            }
        }

        private void FiltrarIndisponibilidadesPorData(DateTime dataSelecionada)
        {
            try
            {
                // Busca todas as indisponibilidades
                List<Indisponibilidade> todasIndisponibilidades = controleDisponibilidade.BuscarTodasIndisponibilidades();

                // Filtra as indisponibilidades para a data selecionada
                var indisponibilidadesFiltradas = todasIndisponibilidades.Where(ind =>
                    (ind.Tipo == "Específico" && ind.DataEspecifica.HasValue && ind.DataEspecifica.Value.Date == dataSelecionada) ||
                    (ind.Tipo == "Semanal" && DiaSemanaParaDayOfWeek(ind.DiaSemana) == dataSelecionada.DayOfWeek)
                ).ToList();

                // Atualiza o DataGridView com os dados filtrados
                AtualizarGrid(indisponibilidadesFiltradas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar indisponibilidades: {ex.Message}");
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            CarregarIndisponibilidades();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se uma linha está selecionada no DataGridView
                if (dataGridViewIndisponibilidades.SelectedRows.Count > 0)
                {
                    // Obtém o ID da indisponibilidade da linha selecionada
                    int id = Convert.ToInt32(dataGridViewIndisponibilidades.SelectedRows[0].Cells["Id"].Value);

                    // Solicita confirmação ao usuário
                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta indisponibilidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Chama o método de exclusão na classe de controle
                        controleDisponibilidade.DeletarIndisponibilidade(id);

                        // Atualiza o DataGridView após a exclusão
                        CarregarIndisponibilidades();

                        MessageBox.Show("Indisponibilidade deletada com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma indisponibilidade para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar indisponibilidade: {ex.Message}");
            }
        }

        // Converte o nome do dia da semana para DayOfWeek
        private DayOfWeek DiaSemanaParaDayOfWeek(string diaSemana)
        {
            return diaSemana switch
            {
                "Domingo" => DayOfWeek.Sunday,
                "Segunda" => DayOfWeek.Monday,
                "Terça" => DayOfWeek.Tuesday,
                "Quarta" => DayOfWeek.Wednesday,
                "Quinta" => DayOfWeek.Thursday,
                "Sexta" => DayOfWeek.Friday,
                "Sábado" => DayOfWeek.Saturday,
                _ => throw new ArgumentException("Dia da semana inválido")
            };
        }

        private void btnAnoAnterior_Click(object sender, EventArgs e)
        {
            anoAtual--;
            AtualizarCalendario();
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            mesAtual--;
            if (mesAtual < 1)
            {
                mesAtual = 12;
                anoAtual--;
            }
            AtualizarCalendario();
        }

        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            mesAtual++;
            if (mesAtual > 12)
            {
                mesAtual = 1;
                anoAtual++;
            }
            AtualizarCalendario();
        }

        private void btnProximoAno_Click(object sender, EventArgs e)
        {
            anoAtual++;
            AtualizarCalendario();
        }
    }
}
