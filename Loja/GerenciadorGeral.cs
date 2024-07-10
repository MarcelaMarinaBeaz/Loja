﻿using System;
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
            produtos.Add(new Produto(1, "Civic G10", 265900, 78));
            produtos.Add(new Produto(2, "Bugatti Divo", 800000, 78));
            produtos.Add(new Produto(3, "Aspark Owl.", 16000000, 78));
            produtos.Add(new Produto(4, "CRX/Del Sol.", 265900, 78));
            produtos.Add(new Produto(5, "Civic EX", 259900, 78));
            produtos.Add(new Produto(6, "Civic Si", 159900, 78));
            produtos.Add(new Produto(7, "Civic Sport", 87900, 78));
            produtos.Add(new Produto(8, "Civic Touring", 259900, 78));
            produtos.Add(new Produto(9, " Honda New Civic LXS", 6900000, 78));
            produtos.Add(new Produto(10, "Honda Civic LXR ", 699000, 78));
            produtos.Add(new Produto(11, "Honda Civic EXL", 1079000, 78));
            produtos.Add(new Produto(12, "Honda Civic LXR", 757000, 78));
            produtos.Add(new Produto(13, "Renault Kwid", 71200, 78));
            produtos.Add(new Produto(14, "Fiat Mobi", 71900, 78));
            produtos.Add(new Produto(15, " Citroën C3", 72600, 78));
            produtos.Add(new Produto(16, "Hyundai HB20", 82500, 78));
            produtos.Add(new Produto(17, "Fiat Argo", 82610, 78));
            produtos.Add(new Produto(18, "Renault Stepway", 84690, 78));
            produtos.Add(new Produto(19, "Chevrolet Onix", 86930, 78));
            produtos.Add(new Produto(20, "Volkswagen Polo Track", 87779, 78));
            produtos.Add(new Produto(21, "Fiat Strada", 80000, 78));
            produtos.Add(new Produto(22, "VW Polo", 89000, 78));
            produtos.Add(new Produto(23, "Fiat Mobi", 76000, 78));
            produtos.Add(new Produto(24, "Volkswagen Polo", 12900, 78));
            produtos.Add(new Produto(25, "BMW", 636950, 78));
            produtos.Add(new Produto(26, "Jaguar", 670500, 78));
            produtos.Add(new Produto(27, "Velar", 703500, 78));
            produtos.Add(new Produto(28, "Aston Martin.", 36000000, 78));
            produtos.Add(new Produto(29, "Lamborghini.", 38000000, 78));
            produtos.Add(new Produto(30, "Rolls Royce", 5999990, 78));
            produtos.Add(new Produto(31, "Impala", 180000, 76));

            //Usuarios
            Usuarios.Add(new Usuario(1, "Julia", "julia@gmail.com", "Rua ..... .. .... n°50"));
            Usuarios.Add(new Usuario(2, "Marcela", "marcela@gmail.com", "Rua ..... .. .... n°105"));
            Usuarios.Add(new Usuario(3, "Paulo", "pauulo@gmail.com", "Rua ..... .. .... n°500"));
        }

       
        //Listar produto
        public void ListarProduto()
        {
            Console.WriteLine("-------------Lista de Produto-------------");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine("---------------------------------------");
                produto.ExibirDetalhesDoProduto();
               
            }
            Console.WriteLine("------------------------------------------");
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            int novoID = Usuarios.Max(selector: usuario => usuario.PegarId() + 1);
            usuario.AlterarId(novoID);
            Usuarios.Add(usuario);
        }

        public void AdicionarItemNoCarrinho()
        {

            int acaoS = -1;
            while (acaoS < 32 || acaoS >= 1)
            {
                Console.WriteLine("Seu item foi adicionado no carrinho!!!!");
                acaoS = int.Parse(Console.ReadLine());

                if (acaoS > 31 || acaoS < 1)
                {
                    Console.WriteLine("Açao invalida!!!!");
                }
            }
            return;
        }

        public void MostrarCarrinhoItem()
        {
            Console.WriteLine("------------- Itens -------------");
            foreach (Produto produtos in produtos)
            {
                produtos.MostrarItemNoCarrinho();
            }
            Console.WriteLine("------------------------------------------");
        }

        public void  ListarCliente()
        {
            Console.WriteLine("-------------Lista de Cliente-------------");
            foreach (Usuario Usuarios in Usuarios)
            {
                Console.WriteLine("---------------------------------------");
                Usuarios.ExibirDetalhesUsuario();
              
            }
            Console.WriteLine("------------------------------------------");
        }


        public void ExcluirProduto(Produto produto)
        {
            produtos.Remove(produto);
        }

    }

        
}



