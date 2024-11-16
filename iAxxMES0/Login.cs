using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAxxMES0
{
    internal class Login
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string LoginNome { get; set; }
        public string Senha { get; set; }

        // Construtor
        public Login(int id, int usuarioId, string loginNome, string senha)
        {
            Id = id;
            UsuarioId = usuarioId;
            LoginNome = loginNome;
            Senha = senha;
        }

        // Construtor vazio
        public Login() { }
    }
}
