﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Sistema
    {
        public Usuario usuario { get; set; }
        public GerenciadorGeral ger { get; set; }
        public Produto P { get; set; }
       
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
                ListarItem();
            }
            else if (acao == 3)
            {
                AdicionarItemNoCarrinho();
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
            P.ListarProduto();
        }

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
                                  "\n30 - Rolls Royce");
                Console.WriteLine("Digite qual Produto deseja adicionar No carrinho??");
            int acao= 0;
            if (acao >= 1 || acao <= 30)
            {
                Console.WriteLine("Seu Item foi adicionado ao carrinho");
            }
            else
            {
                Console.WriteLine("Digite uma ação valida!!!!!!!!!!!");
            }
           
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

        }
        private void FinalizarPedido()
        {

        }
        
        
    }
}
