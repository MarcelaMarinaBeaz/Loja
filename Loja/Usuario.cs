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



        public Usuario(int id, string nome, string email, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            
        }
        public int PegarId()
        {
            return id;
        }

        public Usuario()
        {
        }

        public void ExibirDetalhesUsuario()
        {

            Console.WriteLine($"ID do usuario: {id}" +
                              $"\nNome do Usuario: {nome}  " +
                              $"\nEmail do Usuario: {email}" +
                              $"\nEndereço do Usuario: {endereco}");
        }
        public void AlterarId(int Id)
        {
            id = Id;
        }

        public void AlterarNome(string Nome)
        {
            Nome = nome;
        }

    }
}
