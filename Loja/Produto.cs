using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Produto
    {
        private int id { get; set; }
        private string nome { get; set; }
       private double preco { get; set;}
        private int Quant_estoque { get; set; }
        private double cupom { get; set; }
       

        public Produto(int id, string nome, double preco, int Quant_estoque)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.Quant_estoque = Quant_estoque;
        }
        public int PegarID()
        {
            return id;
        }



        public void ExibirDetalhesDoProduto()
        {
            Console.WriteLine("-------------------Detalhes dos Produtos------------------");
            Console.WriteLine($"\nId: {id}" +
                              $"\nNome: {nome}" +
                              $"\nPreço: {preco}" +
                              $"\nEstoque: {Quant_estoque}");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void MostrarItemNoCarrinho()
        {
            Console.WriteLine("-------------------Seu Item No Carrinho------------------");
            Console.WriteLine($"\nId: {id}" +
                              $"\nNome: {nome}" +
                              $"\nPreço: {preco}" +
                              $"\nEstoque: {Quant_estoque}");
            Console.WriteLine("-----------------------------------------------------------");
        }
        
        

    }

    
}
