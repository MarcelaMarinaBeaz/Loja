using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Usuario
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string endereco { get; set; }

        public int PegarId()
        {
            return id;
        }

        public Usuario(int id, string nome, string email, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            
        }
        public void ExibirDetalhesUsuario()
        {

            Console.WriteLine($"ID do usuario: {id}" +
                              $"Nome do Usuario: {nome}  " +
                              $"Email do Usuario: {email}" +
                              $"Endereço do Usuario: {endereco}");
        }
        public void AlterarId(int Id)
        {
            id = Id;
        }
        
        public void EditarUsuario()
        {           
           
            
                ExibirDetalhesUsuario();
                Console.WriteLine("Qual id do usuario que deseja editar?");
                int idEscolhido = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------Cliente-----------------");
                Console.WriteLine($"1 - Nome do Usuario  " +
                                 $"\n2 - Email do Usuario " +
                                 $"\n3 - Endereço do Usuario ");
                Console.WriteLine("Qual area Deseja editar???");


            int acaoSolicitada = int.Parse(Console.ReadLine());

            gerenciadorGeral.EditarU(nome, email, endereco);

        }
    }
}
