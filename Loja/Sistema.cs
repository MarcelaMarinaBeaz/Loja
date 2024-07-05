using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Sistema
    {
        public Usuario usuario { get; set; }
        public GerenciadorGeral ger { get; set; }
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
                CalcularFret();
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
        private void CalcularFret()
        {
            Console.WriteLine("---------------------------Calcular Valor do Fretev---------------------------");
            Console.WriteLine($"1 - Acre (AC)" +
                              $"\n2 - Alagoas (AL)" +
                              $"\n3 - Amapá (AP)" +
                              $"\n4 - Amazonas (AM)" +
                              $"\n5 - Bahia (BA)" +
                              $"\n6 - Ceará (CE)" +
                              $"\n7 - Espírito Santo (ES)" +
                              $"\n8 - Goiás (GO) " +
                              $"\n9 - Maranhão (MA) " +
                              $"\n10 - Mato Grosso (MT) " +
                              $"\n11 - Mato Grosso do Sul (MS) " +
                              $"\n12 - Minas Gerais (MG) " +
                              $"\n13 - Pará (PA) " +
                              $"\n14 - Paraíba (PB) " +
                              $"\n15 - Paraná (PR)" +
                              $"\n16 - Pernanbuco (PE) " +
                              $"\n17 - Piauí (PI) " +
                              $"\n18 - Rio de Janeiro (RJ) " +
                              $"\n19 - Rio Grande do Norte (RN)" +
                              $"\n20 - Rio Grande so Sul (RS) " +
                              $"\n21 - Rondônia (RO)" +
                              $"\n22 - Roraima (RR) " +
                              $"\n23 - Santa Catarina (SC)" +
                              $"\n24 - São Paulo (SP) " +
                              $"\n25 - Sergipe (SE) " +
                              $"\n26 - Tocantins (TO)");
            Console.WriteLine($"Qual a sigla do estado que voce mora??");


            Console.WriteLine("------------------------------------------------------------------------------");
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
