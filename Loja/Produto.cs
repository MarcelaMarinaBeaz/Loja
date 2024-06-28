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

        public Produto(int id, string nome, double preco, int Quant_estoque)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.Quant_estoque = Quant_estoque;
        }
        public void IniciarSistema()
        {
            Console.WriteLine("-------------------Lojas E&M-----------------");
            Console.WriteLine("1 - Cadastro do Usuário" +
                              "2 - Listar Item" +
                              "3 - Adicionar Item no Carrinho" +
                              "4 - Mostrar Item do Carrinho" +
                              "5 - Adicionar item no Estoque" +
                              "6 - Editar item" +
                              "7 - Excluir" +
                              "8 - Realinhar fluxo do estoque" +
                              "9 - Cadastrar cupom" +
                             "10 - Calcular frete" +
                             "11 - Finalizar Pedido" +
                             "------------------------------------------------");

        }
        public void RealizarAcao(int acao )
        {
            if (acao==1)
            {

            }
            else if(acao==2)
            {

            }
            else if(acao==3)
            {

            }
            else if(acao == 4)
            {

            }
            else if (acao == 5)
            {

            }
            else if (acao == 6)
            {

            }
            else if (acao == 7)
            {

            }
            else if (acao == 8)
            {

            }
            else if (acao == 9)
            {

            }
            else if (acao == 10)
            {

            }
            else if (acao == 11)
            {

            }
        }
        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao <= 0 || acao > 11)
            {
                Console.WriteLine($"Qual ação deseja fazer ?");
                acao = int.Parse(Console.ReadLine());

                if (acao > 11)
                {
                    Console.WriteLine($"Erro !!!!!!!!" +
                        $"\n Digite uma ação valido");
                }
            }
            return acao;

        }
        public void ListarItem()
        {

        }
        private void AdicionarEstoque()
        {

        }
        public void EditarItem()
        {

        }
        private void ExcluirItem()
        {

        }
        private void RealinharEstoque()
        {

        }
        private void CadastrarCupom()
        {

        }
        private void CalcularCupom()
        {

        }
        private void FinalizarPedido()
        {

        }
        public void ListarAcao()
        {

        }
        private void SomarTotal()
        {

        }
        private void SomarItem()
        {

        }
    }
}
