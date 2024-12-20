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
        private ControleCalendario controleCalendario;
        private int anoAtual;
        private int mesAtual;
        private int calendarioIdAtual;

        public frmCalendario()
        {
            InitializeComponent();
            controleDisponibilidade = new ControleDisponibilidade();
            controleCalendario = new ControleCalendario();
            anoAtual = DateTime.Today.Year;
            mesAtual = DateTime.Today.Month;
            InicializarCalendario();
            CarregarCalendarios();
        }

        // Método para carregar os calendários disponíveis no ComboBox
        private void CarregarCalendarios()
        {
            try
            {
                List<Calendario> calendarios = controleCalendario.ObterTodosCalendarios();

                cmbCalendarios.DisplayMember = "Nome";
                cmbCalendarios.ValueMember = "Id";
                cmbCalendarios.DataSource = calendarios;

                cmbCalendarios.SelectedIndexChanged += cmbCalendarios_SelectedIndexChanged;

                if (calendarios.Count > 0)
                {
                    calendarioIdAtual = calendarios[0].Id;
                    CarregarIndisponibilidades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar calendários: {ex.Message}");
            }
        }

        // Inicializa o calendário personalizado (DataGridView)
        private void InicializarCalendario()
        {
            dgvCalendario.ColumnCount = 7;
            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                dgvCalendario.Columns[i].HeaderText = diasSemana[i];
            }

            dgvCalendario.RowHeadersVisible = false;
            dgvCalendario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCalendario.ReadOnly = true;
        }

        // Método auxiliar para obter o nome do mês
        private string ObterNomeDoMes(int mes)
        {
            var culturaBrasileira = new System.Globalization.CultureInfo("pt-BR");
            return culturaBrasileira.DateTimeFormat.GetMonthName(mes);
        }

        // Método para determinar a cor com base na duração
        private Color DeterminarCorPorDuracao(TimeSpan duracao)
        {
            if (duracao.TotalHours >= 23.59)
                return Color.Gray; // Dia inteiro
            else if (duracao.TotalHours >= 18)
                return Color.DarkRed; // >= 18 horas: Vermelho Escuro
            else if (duracao.TotalHours >= 12)
                return Color.Red; // >= 12 horas: Vermelho
            else if (duracao.TotalHours >= 8)
                return Color.OrangeRed; // >= 8 horas: Laranja Escuro ou Vermelho Claro
            else if (duracao.TotalHours >= 4)
                return Color.Orange; // >= 4 horas: Laranja
            else if (duracao.TotalHours >= 2)
                return Color.DarkOrange; // >= 2 horas: Amarelo Escuro ou Laranja Claro
            else
                return Color.LightYellow; // < 2 horas: Amarelo Claro
        }

        // Método para calcular a duração total mesclando intervalos sobrepostos
        private TimeSpan CalcularDuracaoMesclada(List<Indisponibilidade> indisponibilidades)
        {
            var intervalos = indisponibilidades
                .Select(ind => new Tuple<TimeSpan, TimeSpan>(ind.HorarioInicio, ind.HorarioFim))
                .OrderBy(t => t.Item1)
                .ToList();

            Stack<Tuple<TimeSpan, TimeSpan>> stack = new Stack<Tuple<TimeSpan, TimeSpan>>();
            stack.Push(intervalos[0]);

            for (int i = 1; i < intervalos.Count; i++)
            {
                var topo = stack.Peek();
                var atual = intervalos[i];

                if (atual.Item1 <= topo.Item2) // Sobreposição
                {
                    // Mescla os intervalos
                    stack.Pop();
                    stack.Push(new Tuple<TimeSpan, TimeSpan>(topo.Item1,
                        topo.Item2 > atual.Item2 ? topo.Item2 : atual.Item2));
                }
                else
                {
                    stack.Push(atual);
                }
            }

            // Soma as durações dos intervalos mesclados
            TimeSpan duracaoTotal = TimeSpan.Zero;
            foreach (var intervalo in stack)
            {
                duracaoTotal += intervalo.Item2 - intervalo.Item1;
            }

            return duracaoTotal;
        }

        // Atualiza o calendário para o mês atual
        private void AtualizarCalendario(List<Indisponibilidade> indisponibilidades)
        {
            lblMesAno.Text = $"{ObterNomeDoMes(mesAtual)} de {anoAtual}";
            dgvCalendario.Rows.Clear();

            DateTime primeiroDiaDoMes = new DateTime(anoAtual, mesAtual, 1);
            int diasNoMes = DateTime.DaysInMonth(anoAtual, mesAtual);

            int diaAtual = 1;
            int diaDaSemana = (int)primeiroDiaDoMes.DayOfWeek;

            for (int semana = 0; diaAtual <= diasNoMes; semana++)
            {
                dgvCalendario.Rows.Add();
                for (int dia = 0; dia < 7; dia++)
                {
                    if (semana == 0 && dia < diaDaSemana || diaAtual > diasNoMes)
                    {
                        dgvCalendario.Rows[semana].Cells[dia].Value = "";
                    }
                    else
                    {
                        DateTime dataAtual = new DateTime(anoAtual, mesAtual, diaAtual);
                        dgvCalendario.Rows[semana].Cells[dia].Value = diaAtual.ToString();
                        dgvCalendario.Rows[semana].Cells[dia].Tag = dataAtual;

                        var indisponibilidadesDoDia = indisponibilidades
                            .Where(ind => ind.DataEspecifica.Date == dataAtual.Date)
                            .ToList();

                        if (indisponibilidadesDoDia.Any())
                        {
                            // Calcular a duração total mesclando intervalos
                            TimeSpan totalDuracao = CalcularDuracaoMesclada(indisponibilidadesDoDia);

                            // Determinar a cor com base na duração total
                            Color cor = DeterminarCorPorDuracao(totalDuracao);
                            dgvCalendario.Rows[semana].Cells[dia].Style.BackColor = cor;

                            // Adicionar tooltip com detalhes
                            dgvCalendario.Rows[semana].Cells[dia].ToolTipText =
                                $"Total de Indisponibilidade: {totalDuracao.Hours}h {totalDuracao.Minutes}min";
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
                List<Indisponibilidade> indisponibilidades = controleDisponibilidade.BuscarIndisponibilidadesPorCalendario(calendarioIdAtual);
                AtualizarCalendario(indisponibilidades);
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
            if (dataGridViewIndisponibilidades.Columns.Count == 0)
            {
                dataGridViewIndisponibilidades.Columns.Add("Id", "Id");
                dataGridViewIndisponibilidades.Columns.Add("Data", "Data");
                dataGridViewIndisponibilidades.Columns.Add("HorarioInicio", "Início");
                dataGridViewIndisponibilidades.Columns.Add("HorarioFim", "Fim");
                dataGridViewIndisponibilidades.Columns.Add("Motivo", "Motivo");

                dataGridViewIndisponibilidades.Columns["Id"].Visible = false;
            }

            dataGridViewIndisponibilidades.Rows.Clear();

            foreach (var indisponibilidade in indisponibilidades)
            {
                dataGridViewIndisponibilidades.Rows.Add(
                    indisponibilidade.Id,
                    indisponibilidade.DataEspecifica.ToString("dd/MM/yyyy"),
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
                List<Indisponibilidade> todasIndisponibilidades = controleDisponibilidade.BuscarIndisponibilidadesPorCalendario(calendarioIdAtual);

                var indisponibilidadesFiltradas = todasIndisponibilidades
                    .Where(ind => ind.DataEspecifica == dataSelecionada.Date)
                    .ToList();

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

        // Converte dia da semana para DayOfWeek
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
            CarregarIndisponibilidades();
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            mesAtual--;
            if (mesAtual < 1)
            {
                mesAtual = 12;
                anoAtual--;
            }
            CarregarIndisponibilidades();
        }

        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            mesAtual++;
            if (mesAtual > 12)
            {
                mesAtual = 1;
                anoAtual++;
            }
            CarregarIndisponibilidades();
        }

        private void btnProximoAno_Click(object sender, EventArgs e)
        {
            anoAtual++;
            CarregarIndisponibilidades();
        }

        private void cmbCalendarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCalendarios.SelectedValue is int selectedId)
            {
                calendarioIdAtual = selectedId;
                CarregarIndisponibilidades();
            }
        }
    }
}
