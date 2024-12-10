using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class Artigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Composicao_Id { get; set; }
        public decimal Composicao { get; set; }
        public int RPM_Min { get; set; }
        public int RPM_Max { get; set; }
        public int RPM_Media { get; set; }
    }
}
