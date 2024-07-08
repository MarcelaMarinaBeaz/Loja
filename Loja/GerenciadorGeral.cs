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
        List<Produto> produtos { get; set; }

        public GerenciadorGeral() 
        {
            Usuarios = new List<Usuario>();
            produtos = new List<Produto>();
            InicializarSistema();
        }
        public void InicializarSistema()
        {
            produtos.Add(new Produto(1, "Civic G10", 265.900, 78));
            produtos.Add(new Produto(2, "Bugatti Divo", 800.000, 78));
            produtos.Add(new Produto(3, "Aspark Owl.", 16.000000, 78));
            produtos.Add(new Produto(4, "CRX/Del Sol.", 265.900, 78));
            produtos.Add(new Produto(5, "Civic EX", 259.900, 78));
            produtos.Add(new Produto(6, "Civic Si", 159.900, 78));
            produtos.Add(new Produto(7, "Civic Sport", 87.900, 78));
            produtos.Add(new Produto(8, "Civic Touring", 259.900, 78));
            produtos.Add(new Produto(9, " Honda New Civic LXS", 69.00000, 78));
            produtos.Add(new Produto(10, "Honda Civic LXR ", 69.9000, 78));
            produtos.Add(new Produto(11, "Honda Civic EXL", 107.9000, 78));
            produtos.Add(new Produto(12, "Honda Civic LXR", 75.7000, 78));
            produtos.Add(new Produto(13, "Renault Kwid", 71.200, 78));
            produtos.Add(new Produto(14, "Fiat Mobi", 71.900, 78));
            produtos.Add(new Produto(15, " Citroën C3", 72.600, 78));
            produtos.Add(new Produto(16, "Hyundai HB20", 82.500, 78));
            produtos.Add(new Produto(17, "Fiat Argo", 82.610, 78));
            produtos.Add(new Produto(18, "Renault Stepway", 84.690, 78));
            produtos.Add(new Produto(19, "Chevrolet Onix", 86.930, 78));
            produtos.Add(new Produto(20, "Volkswagen Polo Track", 87.779, 78));
            produtos.Add(new Produto(21, "Fiat Strada", 8.0000, 78));
            produtos.Add(new Produto(22, "VW Polo", 8.9000, 78));
            produtos.Add(new Produto(23, "Fiat Mobi", 7.6000, 78));
            produtos.Add(new Produto(24, "Volkswagen Polo", 12.900, 78));
            produtos.Add(new Produto(25, "BMW", 636.950, 78));
            produtos.Add(new Produto(26, "Jaguar", 670.500, 78));
            produtos.Add(new Produto(27, "Velar", 703.500, 78));
            produtos.Add(new Produto(28, "Aston Martin.", 36.000000, 78));
            produtos.Add(new Produto(29, "Lamborghini.", 38.000000, 78));
            produtos.Add(new Produto(30, "Rolls Royce", 5.999990, 78));
        }
        //Listar produto
        public void ListarProduto()
        {
            Console.WriteLine("-------------Lista de Produto-------------");
            foreach (Produto produto in produtos)
            {
                produto.ExibirDetalhesDoProduto();
            }
            Console.WriteLine("------------------------------------------");
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            int novoID = Usuarios.Max(usuario => usuario.PegarId() + 1);
            usuario.AlterarId(novoID);
            Usuarios.Add(usuario);
        }

        public void AdicionarItemNoCarrinho()
        {

            int acaoS = -1;
            while (acaoS < 31 || acaoS >= 1)
            {
                Console.WriteLine("Seu item foi adicionado no carrinho!!!!");
                acaoS = int.Parse(Console.ReadLine());

                if (acaoS > 30 || acaoS < 1)
                {
                    Console.WriteLine("Açao invalida!!!!");
                }
            }
            return;
        }

        public void  ListarCliente()
        {
            Console.WriteLine("-------------Lista de Cliente-------------");
            foreach (Usuario Usuarios in Usuarios)
            {
                Usuarios.ExibirDetalhesUsuario();
            }
            Console.WriteLine("------------------------------------------");
        }




        }

        
    }

}

