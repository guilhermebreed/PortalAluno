using PortalAlunoModel.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAlunoApplication.Application
{
    public class AutenticarApplication
    {
        public Usuario Autenticar(String IdUsuario, String senha)
        {
            Usuario usuario = new Usuario();
            usuario.Autenticado = "N";
            usuario.Mensagem = "";

            if(string.IsNullOrEmpty(IdUsuario))
            {
                usuario.Mensagem = "Usuário não informado";
                return usuario;
            }

            if (string.IsNullOrEmpty(senha))
            {
                usuario.Mensagem = "Senha não informada";
                return usuario;
            }

            if ((IdUsuario.Trim() != "g") || (senha.Trim() != "gui"))
            {
                usuario.Mensagem = "Usuário/senha inválidos";
                return usuario;
            }

            usuario.Autenticado = "S";
            usuario.Nome = "Guilherme Silva";

            return usuario;
        }
    }
}
