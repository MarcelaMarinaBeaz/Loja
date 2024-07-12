using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Sistema
    {
        public Usuario usuario { get; set; }
        public GerenciadorGeral ger { get; set; }

        public Sistema()
        {
            usuario = new Usuario();
            ger = new GerenciadorGeral();

        }


        public void IniciarSistema()
        {
            //Repetição do Menu
            int acaoSolicitada = -1;
            while (acaoSolicitada < 0 || acaoSolicitada > 9)
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
                              "\n7 - Cadastrar cupom" +
                              "\n8 - Calcular frete" +
                              "\n9 - Finalizar Pedido" +
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
                EditarItem();
            }
            else if (acao == 6)
            {
                ExcluirItem();
            }
            else if (acao == 7)
            {
                CadastrarCupom();
            }
            else if (acao == 8)
            {
                CalcularFret();
            }
            else if (acao == 9)
            {
                FinalizarPedido();
            }

        }


        //Validar de ação do usuario 
        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao <= 0 || acao > 9)
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
            while (acaoSolicitada > 3 || acaoSolicitada < 0)
            {
                Console.WriteLine("------------------ Cadastrar Usuario ------------------ ");
                Console.WriteLine($"1 - Cadastrar " +
                               $"\n2 - Editar Cadastro" +
                               $"\n3 - Listar Usuarios");
                Console.WriteLine($"Qual ação deseja realizar?");
                acaoSolicitada = int.Parse(Console.ReadLine());

                //Cadastrar Cliente
                if (acaoSolicitada == 1)
                {
                    int id = 0;

                    Console.WriteLine($"Digite o seu nome");
                    string Nome = Console.ReadLine();

                    Console.WriteLine($"Digite seu email");
                    string Email = Console.ReadLine();

                    Console.WriteLine($"Digite o Endereso de sua casa");
                    string Endereco = Console.ReadLine();

                    Usuario u = new Usuario(id, Nome, Email, Endereco);

                    ger.AdicionarUsuario(u);

                }
                //Editar Cliente 
                else if (acaoSolicitada == 2)
                {
                    int acaoE = -1;
                    while (acaoE > 3 || acaoE < 0)
                    {
                        ger.ListarCliente();
                        Console.WriteLine("Qual o id do usuario que deseja editar ?");
                        int IDescolido = int.Parse(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine($"1 - Editar Nome" +
                                  $"\n2 - Editar Email" +
                                  $"\n3 - Editar Endereço");
                        Console.WriteLine("Qual area Deseja editar???");
                        acaoE = int.Parse(Console.ReadLine());

                        ger.EditarCliente(acaoE, IDescolido);

                    }
                }
                //Listar Cliente
                else if (acaoSolicitada == 3)
                {
                    ger.ListarCliente();
                }
                else
                {
                    Console.WriteLine("Ação invalida !!!!!!!!!!!" +
                                      "\nEscolha uma opição valida");
                }
                Console.WriteLine("--------------------------------------------------------");

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

        //5
        public void EditarItem()
        {

            int acao = 0;
            Console.WriteLine("Qual campo voce deseja editar??" +
                              "\n1 - ID" +
                              "\n2 - Nome");
            if (acao == 1)
            {
                Console.WriteLine("Digite um novo ID??");
            }
            else if (acao == 2)
            {
                Console.WriteLine("Digite um Novo Nome??");
            }
            else
            {
                Console.WriteLine("\nERRO!!!!!" +
                                  "\nDigite um Campo valido!!!!");
            }
            return;
        }

        //6
        private void ExcluirItem()
        {
            int pro = 0;
            int produ = 0;

            ger.ListarProduto();
            Console.WriteLine("Qual ID do produto deseja Excluir??");
            pro = int.Parse(Console.ReadLine());


            Produto produto = ger.BuscarProdutoPorId(pro);
            ger.ExcluirProduto(produto);


        }

        //7
        private void CadastrarCupom()
        {
            int acaoS = -1;
            while (acaoS > 1 || acaoS > 2)
            {
                Console.WriteLine($"1 - Ver Cupons Disponiveis" +
                                  $"\n2 - Cadasrar Cupom" +
                                  $"\nQual ação deseja realizar ??");
                acaoS = int.Parse(Console.ReadLine());

                if (acaoS == 1)
                {
                    ger.ListarCupom();
                }
                else if (acaoS == 2)
                {
                    int id = 0;
                    Console.WriteLine("Qual  p nome do novo Cupom que deseja adicionar ?");
                    string nomeCupom = Console.ReadLine();

                    Console.WriteLine("Qual e o codigo dele ?");
                    string cod = Console.ReadLine();

                    Console.WriteLine("Qual e o Valor do cupom de desconto ?? ");
                    double valorCupom = double.Parse(Console.ReadLine());

                    Cupom c = new Cupom(id, nomeCupom, cod, valorCupom);

                    ger.AdicionarUsuario(c);
                }
                else
                {
                    Console.WriteLine("Opição invalida !!!!!!!!!!!!!!" +
                                      "\nEscolha uma opição invalida");
                }
            }

        }




        //8
        private void CalcularFret()
        {
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


        //9  
        private void FinalizarPedido()
        {
            ger.Finalizar();

            Console.WriteLine("\n----------------------Atenção----------------------" +
                              "\nO seu pedido sera calculado: o Valor do Produto, do" +
                              "\nfrete mais o valor de cupom de Desconto, MAS ANTES " +
                              "\nESCOLHA SE DESEJA OU NÃO FINALIZAR O SEU PEDIDO!!!!!");



            int acao = 0;
            while (acao > 1 || acao < 2)
            {

                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine($"\n1 - Finalizar Pedido" +
                                  $"\n2 - Cancelar seu Pedido");
                Console.WriteLine("\n--------------------------------------------------");
                acao = int.Parse(Console.ReadLine());
                if (acao == 1)
                {
                    ger.Finalizar();
                    double preco = 265.900;
                    double frete = 60.00;
                    double cupom = 30.00;
                    DateTime hoje = new DateTime(2024, 10, 07, 8, 30, 25);

                    Console.WriteLine($"\n--------------------------------------------------------" +
                                  $"\nSeu pedido foi finalizado no dia {hoje} !!!!!" +
                                  $"\nNo valor de {preco + frete - cupom}" +
                                  $"\nVOLTE MAIS VEZES!!!!!!" +
                                  $"\n+--------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("SEU PEDIDO FOI CANCELADO, VOLTE AO INICIO PARA FAZER OUTRA COMPRA!!!!");
                }
              
               
            }
        }
    }
}

