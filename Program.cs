using primeiro_programa.Controller;
using primeiro_programa.Exercicios.ListasELoopsCSharp;

class Program
{
    private static void Main(string[] args)
    {

        //int aleatorio = new Random().Next(1, 101);
        //new CacaAoNumeroSecreto().JogoCacaAoNumeroSecreto(aleatorio);

        //new TiposEFuncoesNoCSharp();
        //new ListasELoopNoCSharp();

        new MenuOpcoes();


        var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>>
        {
            {
                "Ana", new Dictionary<string, List<int>>
                {
                    { "C#", new List<int> { 8, 7, 6 } },
                    { "Java", new List<int> { 7, 6, 5 } },
                    { "Python", new List<int> { 9, 8, 8 } }
                }
            },
            {
                "Kelvin", new Dictionary<string, List<int>>()
                {
                    { "C#", new List<int>{1, 2, 3} }
                }
            }
        };

        var notasAlunos2 = new Dictionary<string, Dictionary<string, List<int>>>
        {
            { 
                "Kelvin", new Dictionary<string, List<int>>()
                {
                    { "C#", new List<int>{1, 2, 3} }
                }
            }
        };

        //Quando utilizado o Dictionary, para cada posição da lista, deve ser aberto um { } e atribuido a chave e valor
        var lista = new Dictionary<string, int> { { "1", 2 }, { "2", 2 } };


    }
}