
using System.Runtime.CompilerServices;

class Program{
    private static void Main(string[] args)
    {

        int aleatorio = new Random().Next(0, 100);
        new CacaAoNumeroSecreto().JogoCacaAoNumeroSecreto(aleatorio);


        //Exercicio exercicios = new Exercicio();
        //exercicios.Exercicio1();
        //exercicios.Exercicio2();
        //exercicios.Exercicio3();
        //exercicios.Exercicio4();

        //Screen Sound
        string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

        Program program = new Program();

        program.ExibirMensagemDeBoasVinda(mensagemDeBoasVindas);
        program.ExibirMensagemDeBoasVinda("\nBoas Vindas ao Screen Sound");
        string opcao = program.ExibirOpcoesDoMenu();

        program.Opcoes(opcao);

    }

    void ExibirMensagemDeBoasVinda(string mensagem){
        Console.WriteLine(mensagem);
    }

    string ExibirOpcoesDoMenu(){
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 5 para sair");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;

        return opcaoEscolhida;
    }

    void Opcoes(String opcao){
        if(!int.TryParse(opcao, out int opcoes)){
            Console.WriteLine("Valor digitado não é numérico.");
        } else {
            int opcaoNumerica = int.Parse(opcao);
            string descricao = "Você digitou a opcao " + opcaoNumerica;
            switch (opcaoNumerica){
                case 1: Console.WriteLine(descricao); 
                    break;
                case 2: Console.WriteLine(descricao);
                    break;
                case 3: Console.WriteLine(descricao);
                    break;
                case 4: Console.WriteLine(descricao);
                    break;
                case 5: Console.WriteLine("Tchau Tchau :)");
                    break;
                default: Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}