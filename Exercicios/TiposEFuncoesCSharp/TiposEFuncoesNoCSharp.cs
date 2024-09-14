class TiposEFuncoesNoCSharp
{

    public TiposEFuncoesNoCSharp()
    {
        //Tipos de Funções o C#
        Exercicio1();
        Exercicio2();
        Exercicio3();
        Exercicio4();
    }

    void Exercicio1()
    {
        /*EX1: Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. 
        Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".*/

        int notaMedia = 6;
        if (notaMedia >= 5)
        {
            Console.WriteLine("Nota suficiente para aprovação.");
        }

    }

    List<string> Exercicio2()
    {
        /*EX2: Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.*/
        List<string> linguagemDeProgramacao = new List<string> { "C#", "Java", "JavaScript" };
        return linguagemDeProgramacao;
    }

    void Exercicio3()
    {
        List<string> linguagens = Exercicio2().ToList();
        /*EX3: Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.*/
        Console.WriteLine(linguagens[0]);
    }

    void Exercicio4()
    {
        /*Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, 
        exibir a n-ésima posição de uma lista.*/
        Console.Write("Informe um numero: ");
        string numeroString = Console.ReadLine()!;
        int numero = int.Parse(numeroString);
        //Console.WriteLine(numero);
        List<string> linguagens = Exercicio2().ToList();
        if (linguagens.Count() < numero - 1)
        {
            Console.WriteLine("Não existe registro para o valor informado.");
        }
        else
        {
            Console.WriteLine(linguagens[numero - 1]);
        }

    }

}