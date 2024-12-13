using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    public class Fibra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Tipo { get; set; }

        // Construtor Vazio
        public Fibra() { }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
