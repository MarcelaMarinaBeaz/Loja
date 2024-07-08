using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Sistema
    {
        public Usuario usuario { get; set; }
        public GerenciadorGeral ger { get; set; }
        public Produto P { get; set; }
       
        public Sistema()
        {
            usuario= new Usuario();
            ger= new GerenciadorGeral();
        }
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
                              "\n5 - Editar item" +
                              "\n6 - Excluir" +
                              "\n7 - Realinhar fluxo do estoque" +
                              "\n8 - Cadastrar cupom" +
                              "\n9 - Calcular frete" +
                              "\n10 - Finalizar Pedido" +
                              "\n------------------------------------------------");

        }
        public void RealizarAcao(int acao)
        {
            if (acao == 1)
            {
                CadastroUsuario(); 
            }
            else if (acao == 2)
            {
                ListarItem();
            }
            else if (acao == 3)
            {
                AdicionarItemNoCarrinho();
            }
            else if (acao == 4)
            {
                MostrarItemNoCarrinho();
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
                CalcularFret();
            }
            else if (acao == 10)
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
        //1
        public void CadastroUsuario()
        {
            int acaoSolicitada = -1;
            while (acaoSolicitada > 2 || acaoSolicitada < 0)
            {
                Console.WriteLine( $"1 - Cadastrar " +
                               $"\n2 - Editar Cadastro");
            Console.WriteLine($"Qual ação deseja realizar?");
             acaoSolicitada = int.Parse(Console.ReadLine());

                if (acaoSolicitada == 1)
                {
                    Console.WriteLine($"Digite o seu nome");
                    string Nome = Console.ReadLine();

                    Console.WriteLine($"Digite seu email");
                    string Email = Console.ReadLine();

                    Console.WriteLine($"Digite o Endereso de sua casa");
                    string Endereco = Console.ReadLine();

                    Usuario u = new Usuario(1, Nome, Email, Endereco);

                    ger.AdicionarUsuario(u);

                }
                else if (acaoSolicitada == 2)
                {
                    int acaoEscolida = -1;
                    while (acaoEscolida > 3 || acaoEscolida < 0)
                    {
                        //usuario.ExibirDetalhesUsuario();
                        Console.WriteLine($"1 - Editar Nome" +
                                  $"2 - Editar Email" +
                                  $"3 - Editar Endereço");
                        Console.WriteLine("Qual area Deseja editar???");
                        acaoEscolida = int.Parse(Console.ReadLine());

                        if (acaoEscolida == 1)
                        {
                            //usuario
                            Console.WriteLine("Novo nome de usuario");
                            string Nome = Console.ReadLine();
                        }
                        else if (acaoEscolida == 2)
                        {
                            //email
                            Console.WriteLine("Novo email do usuario");
                            string Email = Console.ReadLine();
                        }
                        else if (acaoEscolida == 3)
                        {
                            //endereço
                            Console.WriteLine("Novo endereço do usuario");
                           string  Endereco = Console.ReadLine();
                        }
                        else if (acaoEscolida > 3 || acaoEscolida < 0)
                        {
                            Console.WriteLine("Erro!!! Digite uma opção valida");
                        }
                    }
                }
                else if(acaoSolicitada >3 || acaoSolicitada < 0)
                {
                    Console.WriteLine("Ação invalida !!!!!!!!!!!" +
                                      "\nEscolha uma opição valida");
                }
              
            }
           
        }
        //2
        public void ListarItem()
        {
            ger.ListarProduto();
        }
        //3
        private void AdicionarItemNoCarrinho()
        {
            
                Console.WriteLine("-------------ITENS------------");
                Console.WriteLine("\n1 - Civic G10" +
                                  "\n2 - Bugatti Divo" +
                                  "\n3 - Aspark Owl" +
                                  "\n4 - CRX/Del Sol" +
                                  "\n5 - Civic EX " +
                                  "\n6 - Civic Si" +
                                  "\n7 - Civic Sport" +
                                  "\n8 - Civic Touring" +
                                  "\n9 - Honda New Civic LXS" +
                                  "\n10 - Honda Civic LXR" +
                                  "\n11 - Honda Civic EXL" +
                                  "\n12 - Honda Civic LXR" +
                                  "\n13 - Renault Kwid" +
                                  "\n14 - Fiat Mobi" +
                                  "\n15 -  Citroën C3" +
                                  "\n16 - Hyundai HB20" +
                                  "\n17 - Fiat Argo" +
                                  "\n18 - Renault Stepway" +
                                  "\n19 - Chevrolet Onix" +
                                  "\n20 - Volkswagen Polo Track" +
                                  "\n21 - Fiat Strada" +
                                  "\n22 - VW Polo" +
                                  "\n23 - Fiat Mobi" +
                                  "\n24 - Volkswagen Polo" +
                                  "\n25 - BMW" +
                                  "\n26 - Jaguar" +
                                  "\n27 - Velar" +
                                  "\n28 - Aston Martin" +
                                  "\n29 - Lamborghini" +
                                  "\n30 - Rolls Royce" +
                                  "\n31 - Impala " +
                                  "\n---------------------------------");
                Console.WriteLine("Digite qual Produto deseja adicionar No carrinho??");
            int pSelecionada = int.Parse(Console.ReadLine());

            ger.AdicionarItemNoCarrinho();
        }
        //4
        private void MostrarItemNoCarrinho()
        {
           ger.MostrarCarrinhoItem();
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
       
        private void CalcularFret()
        {
            //9
            int acao = -1;
            while (acao < 1 || acao > 26)
            {//começo do while
                Console.WriteLine("---------------------------Calcular Valor do Fretev---------------------------");
                Console.WriteLine($"1 - Acre " +
                                  $"\n2 - Alagoas " +
                                  $"\n3 - Amapá " +
                                  $"\n4 - Amazonas " +
                                  $"\n5 - Bahia " +
                                  $"\n6 - Ceará " +
                                  $"\n7 - Espírito Santo " +
                                  $"\n8 - Goiás  " +
                                  $"\n9 - Maranhão  " +
                                  $"\n10 - Mato Grosso  " +
                                  $"\n11 - Mato Grosso do Sul  " +
                                  $"\n12 - Minas Gerais  " +
                                  $"\n13 - Pará " +
                                  $"\n14 - Paraíba  " +
                                  $"\n15 - Paraná " +
                                  $"\n16 - Pernanbuco  " +
                                  $"\n17 - Piauí  " +
                                  $"\n18 - Rio de Janeiro " +
                                  $"\n19 - Rio Grande do Norte " +
                                  $"\n20 - Rio Grande so Sul  " +
                                  $"\n21 - Rondônia " +
                                  $"\n22 - Roraima  " +
                                  $"\n23 - Santa Catarina " +
                                  $"\n24 - São Paulo  " +
                                  $"\n25 - Sergipe  " +
                                  $"\n26 - Tocantins ");
                Console.WriteLine($"Digite o numero que coresponde a seu Estado");
                acao = int.Parse(Console.ReadLine());

                if (acao == 1)
                {
                    Console.WriteLine("O valor do seu fret é: R$60,00 reais");
                }
                else if (acao == 2)
                {
                    Console.WriteLine("O valor do seu fret é: R$40,00 reais");
                }
                else if (acao == 3)
                {
                    Console.WriteLine("O valor do seu fret é: R$60,00 reais");
                }
                else if (acao == 4)
                {
                    Console.WriteLine("O valor do seu fret é: R$60,00 reais");
                }
                else if (acao == 5)
                {
                    Console.WriteLine("O valor do seu fret é: R$15,00 reais");
                }
                else if (acao == 6)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 7)
                {
                    Console.WriteLine("O valor do seu fret é: R$15,00 reais");
                }
                else if (acao == 8)
                {
                    Console.WriteLine("O valor do seu fret é: R$15,00 reais");
                }
                else if (acao == 9)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 10)
                {
                    Console.WriteLine("O valor do seu fret é: R$40,00 reais");
                }
                else if (acao == 11)
                {
                    Console.WriteLine("O valor do seu fret é: R$20,00 reais");
                }
                else if (acao == 12)
                {
                    //Qualquer pedido em Minas e com Frete Grátiz pois e a sede da empresa
                    Console.WriteLine("Frete Grátiz");
                }
                else if (acao == 13)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 14)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 15)
                {
                    Console.WriteLine("O valor do seu fret é: R$20,00 rais");
                }
                else if (acao == 16)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 17)
                {
                    Console.WriteLine("O valor do seu fret é: R$30,00 reais");
                }
                else if (acao == 18)
                {
                    Console.WriteLine("O valor do seu fret é: R$15,00 reais");
                }
                else if (acao == 19)
                {
                    Console.WriteLine("O valor do seu fret é: R$40,00 reias");
                }
                else if (acao == 20)
                {
                    Console.WriteLine("O valor do seu fret é: R$20,00 reais");
                }
                else if (acao == 21)
                {
                    Console.WriteLine("O valor do seu fret é: R$50,00 reais");
                }
                else if (acao == 22)
                {
                    Console.WriteLine("O valor do seu fret é: R$60,00 reais");
                }
                else if (acao == 23)
                {
                    Console.WriteLine("O valor do seu fret é: R$20,00 reais");
                }
                else if (acao == 24)
                {
                    Console.WriteLine("O valor do seu fret é: R$15,00 reais");
                }
                else if (acao == 25)
                {
                    Console.WriteLine("O valor do seu fret é: R$30,00 reais");
                }
                else if (acao == 26)
                {
                    Console.WriteLine("O valor do seu fret é: R$30,00 reais");
                }
                else
                {
                    Console.WriteLine("Acão invalida !!!!!!!!!");
                    Console.WriteLine($"Erro !!!!!!!!! Erro !!!!!!!!!!!" +
                                      $"\nDigite uma opição valida");
                }
                Console.WriteLine("------------------------------------------------------------------------------");
            }//Final while


            }
            private void FinalizarPedido()
        {

        }
        
        
    }
}
