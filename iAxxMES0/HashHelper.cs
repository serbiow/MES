using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace iAxxMES0
{
    public static class HashHelper
    {
        // Gera um hash da senha com SHA-256 e um salt
        public static string GerarHashComSalt(string senha)
        {
            // Gerar o salt
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            // Concatenar a senha com o salt
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
            byte[] senhaComSalt = senhaBytes.Concat(saltBytes).ToArray();

            // Gerar o hash com SHA-256
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(senhaComSalt);

                // Concatenar o salt no final do hash e retornar como base64
                byte[] hashComSalt = hashBytes.Concat(saltBytes).ToArray();
                return Convert.ToBase64String(hashComSalt);
            }
        }

        // Verifica se a senha digitada gera o mesmo hash armazenado
        public static bool VerificarSenha(string senhaDigitada, string hashArmazenado)
        {
            // Converter o hash armazenado de base64 para bytes
            byte[] hashArmazenadoBytes = Convert.FromBase64String(hashArmazenado);

            // Extrair o hash e o salt do valor armazenado
            byte[] hashBytes = hashArmazenadoBytes.Take(32).ToArray(); // SHA-256 gera 32 bytes
            byte[] saltBytes = hashArmazenadoBytes.Skip(32).Take(16).ToArray(); // Salt é 16 bytes

            // Concatenar a senha digitada com o salt
            byte[] senhaDigitadaBytes = Encoding.UTF8.GetBytes(senhaDigitada);
            byte[] senhaDigitadaComSalt = senhaDigitadaBytes.Concat(saltBytes).ToArray();

            // Gerar o hash da senha digitada
            using (var sha256 = SHA256.Create())
            {
                byte[] hashDigitado = sha256.ComputeHash(senhaDigitadaComSalt);

                // Comparar o hash gerado com o hash armazenado
                return hashBytes.SequenceEqual(hashDigitado);
            }
        }
    }
}
