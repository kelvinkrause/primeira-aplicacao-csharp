
class Program{
    private static void Main(string[] args)
    {
        string mensagemDeBoasVindas = "Seja Bem Vindo";
        Console.WriteLine(mensagemDeBoasVindas);
        string texto = Console.ReadLine();
        Console.WriteLine("* {0} *", texto);
        Console.WriteLine($"# {texto} #");
    }
}