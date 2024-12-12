using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class Artigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Composicao_Id { get; set; }
        public decimal Composicao { get; set; }
        public int RPM_Min { get; set; }
        public int RPM_Max { get; set; }
        public int RPM_Media { get; set; }
        public int Fibra_Id { get; set; }
        public string Fibra_Nome { get; set; }
        public string Fibra_Sigla { get; set; }
        public string Fibra_Tipo { get; set; }
    }
}
