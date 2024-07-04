using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class GerenciadorGeral
    {
        List<Usuario> Usuarios { get; set; }

    public GerenciadorGeral() 
        {
            Usuarios= new List<Usuario>();
        }   
        public void AdicionarUsuario(Usuario usuario)
        {
            int novoID = Usuarios.Max(usuario => usuario.PegarId() + 1);
            usuario.AlterarId(novoID);
            Usuarios.Add(usuario);
        }


       
    }

}

