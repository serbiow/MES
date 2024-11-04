using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class Maquina
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Grupo { get; set; }
        public int RPM { get; set; }
        public string Status { get; set; }
        public string Motivo_Parada { get; set; }
        public int Finura { get; set; }
        public int Diametro { get; set; }
        public int NumeroAlimentadores { get; set; }
        public DateTime DataHoraStatus { get; set; }
    }
}
