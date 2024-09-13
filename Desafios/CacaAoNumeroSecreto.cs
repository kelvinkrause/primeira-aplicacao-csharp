using System;

public class CacaAoNumeroSecreto {
    public void JogoCacaAoNumeroSecreto(int numeroSecreto){
        
        //Console.WriteLine(aleatorio);
        int chute;

        do {
            Console.Write("Tente adivinhar o numero aleatório de 1 a 100 ou insira 0 para sair: ");
            chute = int.Parse(Console.ReadLine()!);

            if(chute != -1){
                if(chute == numeroSecreto){
                    Console.WriteLine("Parabéns você acertou!");
                    break;
                } else if(chute > numeroSecreto){
                    Console.WriteLine("O numero é maior.");
                } else if(chute < numeroSecreto){
                    Console.WriteLine("O numero é menor.");
                }
            }

            Console.WriteLine("O jogo acabou. Parabéns você acertou o numero secreto");

        } while(chute != 0);
    }
}