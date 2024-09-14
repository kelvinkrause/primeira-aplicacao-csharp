using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Controller
{
    public class MenuOpcoes
    {
        //List<string> listaDeBandas = new List<string> {"The Rockets", "Creedence", "The Rolling Stones", "Foghat"};
        Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
        public MenuOpcoes()
        {
            
            listaDeBandas.Add("Linkin Park", new List<int>{ 10, 9, 8});
            listaDeBandas.Add("The Bettles", new List<int>());

            ExibirOpcoesDoMenu();
        }

        void ExibirMensagemDeBoasVinda()
        {
            string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine("\nBoas Vindas ao Screen Sound");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirMensagemDeBoasVinda();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 5 para sair");

            Console.Write("\nDigite sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;

            Opcoes(opcaoEscolhida);
        }

        void Opcoes(String opcao)
        {
            if (!int.TryParse(opcao, out int opcoes))
            {
                Console.WriteLine("Valor digitado não é numérico.");
            }
            else
            {
                int opcaoNumerica = int.Parse(opcao);
                string descricao = "Você digitou a opção " + opcaoNumerica;
                switch (opcaoNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        MostrarTodasBandas();
                        break;
                    case 3:
                        AvaliarUmaBanda();
                        break;
                    case 4:
                        Console.WriteLine(descricao);
                        break;
                    case 5:
                        Console.WriteLine("Tchau Tchau :)");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        void RegistrarBanda()
        {
            Console.Clear();
            CabecalhoOpcoes(" REGISTRO DE BANDA ", "C");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            listaDeBandas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        void MostrarTodasBandas()
        {
            Console.Clear();
            CabecalhoOpcoes(" LISTA DE BANDAS REGISTRADAS ", "C");
            foreach (string banda in listaDeBandas.Keys){
                Console.WriteLine("Banda " + (listaDeBandas.Keys.ToList().IndexOf(banda) + 1) + ": " + banda);
            }
            CabecalhoOpcoes("", "R");
            Console.Write("\nDigite 0 para retornar ao menu ou 1 para sair: ");
            int opcao = int.Parse(Console.ReadLine()!);
            if (opcao == 0)
            {
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            Console.Clear();
        }

        void CabecalhoOpcoes(string titulo, string opcaoCabecalhoOuRodape)
        {

            if(opcaoCabecalhoOuRodape == "C") 
            {
                Console.WriteLine(asteriscos(41));
                Console.WriteLine(asteriscos((41 - titulo.Length) / 2) + titulo + asteriscos((41 - titulo.Length) / 2));
                Console.WriteLine(asteriscos(41) + "\n");
            } else if(opcaoCabecalhoOuRodape == "R")
            {
                Console.WriteLine( "\n" + asteriscos(41));
            }
        
            string asteriscos(int quantidade)
            {
                string asteriscos = "";
                for (int i = 0; i < quantidade; i++)
                {
                    asteriscos += "*";
                }
                return asteriscos;
            }
        }

        void AvaliarUmaBanda()
        {
            Console.Clear();
            CabecalhoOpcoes(" AVALIAR BANDA ", "C");
            Console.Write("\nDigite uma banda que deseje avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (listaDeBandas.ContainsKey(nomeBanda))
            {
                Console.Write($"Qual nota a {nomeBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                listaDeBandas[nomeBanda].Add(nota);
                Console.WriteLine($"A {nota} foi registrada com sucesso para a banda {nomeBanda} com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
                ExibirOpcoesDoMenu();

            }
            else
            {
                Console.WriteLine($"\nA {nomeBanda} não foi encontrado!");
                Console.Write("Digite uma tecla para voltar para o menu principal");
                Console.ReadKey(true);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }

    }
}
