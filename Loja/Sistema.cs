using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Sistema
    {
        public void IniciarSistema()
        {
            //Repetição do Menu
            int acaoSolicitada = -1;
            while (acaoSolicitada != 0)
            {
                Menu();
                int acaoSelecionada = SolicitarAcaoUsuario();
                RealizarAcao(acaoSelecionada);
            }
        }
        public void Menu()
        {
            Console.WriteLine("-------------------Lojas E&M-----------------");
            Console.WriteLine("\n1 - Cadastro do Usuário" +
                              "\n2 - Listar Item" +
                              "\n3 - Adicionar Item no Carrinho" +
                              "\n4 - Mostrar Item do Carrinho" +
                              "\n5 - Adicionar item no Estoque" +
                              "\n6 - Editar item" +
                              "\n7 - Excluir" +
                              "\n8 - Realinhar fluxo do estoque" +
                              "\n9 - Cadastrar cupom" +
                             "\n10 - Calcular frete" +
                             "\n11 - Finalizar Pedido" +
                             "------------------------------------------------");

        }
        public void RealizarAcao(int acao)
        {
            if (acao == 1)
            {
                CadastroUsuario(); 
            }
            else if (acao == 2)
            {

            }
            else if (acao == 3)
            {

            }
            else if (acao == 4)
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

        public void CadastroUsuario()
        {

        }
        public void CadastrarProduto()
        {

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
