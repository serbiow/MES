using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class Indisponibilidade
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // "Semanal" ou "Específico"
        public string DiaSemana { get; set; } // Segunda, Terça, etc.
        public DateTime? DataEspecifica { get; set; } // Nullable para permitir tipos diferentes
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFim { get; set; }
        public string Motivo { get; set; }
    }
}
