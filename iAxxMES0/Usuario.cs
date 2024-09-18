using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Horario { get; set; }
        public string CPF { get; set; }

        // Construtor opcional
        public Usuario(int id, string nome, string cargo, string horario, string cpf)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Horario = horario;
            CPF = cpf;
        }

        // Construtor vazio
        public Usuario() { }
    }
}
