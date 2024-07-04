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
        public void LoginUsuario(Usuario usuario)
        {
            int novoID = Usuarios.Max(usuario => usuario.PegarId() + 1);
            usuario.AlterarId(novoID);
            Usuarios.Add(usuario);
        }
        public void EditarUsuario()
        {

            Console.WriteLine("------------------Cliente-----------------");
            Console.WriteLine($"1 - Nome do Usuario  " +
                             $"\n2 - Email do Usuario " +
                             $"\n3 - Endereço do Usuario ");
            Console.WriteLine("Qual id do usuario que deseja editar?");
            int idEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual area Deseja editar???");


            int acaoSolicitada = int.Parse(Console.ReadLine());

            EditarU(null, null, null);//nome, email, endereco);

        }

        public void EditarU(string nome, string email, string endereco)
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
}

