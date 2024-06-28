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
        public void LoginCliente(Usuario usuario)
        {
            int novoID = Usuarios.Max(usuario => usuario.PegarId() + 1);
            usuario.AlterarId(novoID);
            Usuarios.Add(usuario);
        }
        public void Editar(string nome, string email, string endereco)
        {
            int acaoSolicitada = -1;
            while (acaoSolicitada > 3 || acaoSolicitada < 0)
            {
                if (acaoSolicitada == 1)
                {
                    Console.WriteLine("Novo nome de usuario");
                }
                else if (acaoSolicitada == 2)
                {
                    Console.WriteLine("Novo email do usuario");
                }
                else if (acaoSolicitada == 3)
                {
                    Console.WriteLine("Novo endereço do usuario");
                }
                else if (acaoSolicitada > 3 || acaoSolicitada < 0)
                {
                    Console.WriteLine("Erro!!! Digite uma opção valida");
                }
            }
    }
}
