using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solucao
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}
