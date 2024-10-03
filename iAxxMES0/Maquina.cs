using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class Maquina
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public int RPM { get; set; }
        public string Status { get; set; }
        public string Motivo_Parada { get; set; }
        public string Grupo { get; set; }
    }
}
