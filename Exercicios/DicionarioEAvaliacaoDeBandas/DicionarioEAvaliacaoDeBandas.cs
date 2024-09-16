using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Exercicios.DicionarioEAvaliacaoDeBandas
{
    public class DicionarioEAvaliacaoDeBandas
    {
        public DicionarioEAvaliacaoDeBandas()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
        }

        void Exercicio1()
        {
            /*
             * Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
             */

            Dictionary<string, Dictionary<string, List<int>>> alunosMateriasNotas = new Dictionary<string, Dictionary<string, List<int>>>();

            alunosMateriasNotas.Add("Kelvin", new Dictionary<string, List<int>> {
                { "Português", new List<int> { 10, 5 } },
                { "Geografia", new List<int> { 10, 5 } } });

            string aluno = "Kelvin";
            string materia = "Geografia";

            if (alunosMateriasNotas.ContainsKey(aluno))
            {
                if (alunosMateriasNotas[aluno].ContainsKey(materia))
                {
                    Console.WriteLine($"A nota do Aluno: {aluno} em {materia} é: {alunosMateriasNotas["Kelvin"]["Geografia"].Average()}");
                }
            }
        }

        void Exercicio2(){
            /*
            * Criar um programa que gerencie o estoque de uma loja. 
            * Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
            */

            Dictionary<string, int> produtos = new Dictionary<string, int>();

            produtos.Add("Liquidificador", 10);
            produtos.Add("Geladeira", 10);
            produtos.Add("Fogão", 5);

            Console.Write("Digite o nome de um produto para saber sua quantidade em estoque: ");
            string nomeProduto = Console.ReadLine()!;
            Console.WriteLine(produtos.ContainsKey(nomeProduto) ? $"Produto: {nomeProduto}, Qtd. Estoque: {produtos[nomeProduto].ToString()}" : "Produto não existe no cadastro.");

        }

        void Exercicio3(){
            /*
            * Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
            */

            Dictionary<string, string> perguntasERespostas = new Dictionary<string, string> {
                { "Qual o nome da cidade onde o Kelvin mora? ", "Três Coroas" },
                { "Qual é a idade do Kelvin? ", "27" },
                {"Qual é o esporte atual do Kelvin? ", "Corrida" },
            };

            int pontuacao = 0;

            Console.WriteLine("Bem vindo ao Quiz sobre o Kelvin Krause");

            foreach (string pergunta in perguntasERespostas.Keys){
                Console.WriteLine($"{pergunta}");
                Console.Write("Digite sua responsta: ");
                string responsta = Console.ReadLine()!;

                if(perguntasERespostas[pergunta].ToLower().Equals(responsta.ToLower())){
                    Console.WriteLine("Resposta Correta!\n");
                    pontuacao++;
                } else {
                Console.WriteLine($"Resposta Incorreta. A resposta correta é: {perguntasERespostas[pergunta].ToString()} ;(");
                }
            }

        }


    }
}
