using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Exercicios.ListasELoopsCSharp
{
    public class ListasELoopNoCSharp
    {
        
        public ListasELoopNoCSharp()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            Exercicio4();
        }

        void Exercicio1()
        {
            /*
             * Escrever uma função que a partir de dois números de ponto flutuante a e b 
             * exiba no console o resultado de suas quatro operações básicas 
             * (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
             */
            double num1, num2 = 0;
            Console.Write("Informe o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Informe o segundo numero: ");
            num2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"A SOMA de {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"A SUBTRACAO de {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"A MULTIPLICACAO de {num1} * {num2} = {num1 * num2}");
            Console.WriteLine(num2 == 0 ? $"ERRO: Impossível dividir {num1} por {num2}" : 
                $"A DIVISAO de {num1} / {num2} = {num1 / num2}");
        }

        List<string> Exercicio2()
        {
            /*Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.*/
            List<string> listaDeBandas = new List<string>();
            do
            {
                Console.WriteLine("Digite sua banda ou escreva sair:");
                string banda = Console.ReadLine()!;

                if(banda.ToUpper() == "SAIR") break;
               
                listaDeBandas.Add(banda);
                Console.WriteLine($"Banda {banda} adicionada a lista com sucesso.");
                Console.Clear();

            } while (true);

            return listaDeBandas;
            
        }

        void Exercicio3()
        {
            /*
             * Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, 
             * listadas na lista do exercício anterior, no console.
             */
            List<string> listaDeBandas = Exercicio2();

            if(listaDeBandas.Count == 0)
            {
                Console.WriteLine("Lista vaxia.");
            } else
            {
                foreach(string banda in listaDeBandas)
                {
                    Console.Write("Banda: " + banda);
                }
            }
             
        }

        void Exercicio4()
        {
            /*Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.*/
            List<int> listaDeInteiros = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int soma = 0;
            foreach(int num in listaDeInteiros)
            {
                soma += num;
            }
            Console.WriteLine(soma);
        }

    }
}
