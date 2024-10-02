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
        public string Nivel_Permissao { get; set; }
        public string Registro_Matricula { get; set; }

        // Construtor opcional
        public Usuario(int id, string nome, string nivel_permissao, string registro_matricula)
        {
            Id = id;
            Nome = nome;
            Nivel_Permissao = nivel_permissao;
            Registro_Matricula = registro_matricula;
        }

        // Construtor vazio
        public Usuario() { }
    }
}
