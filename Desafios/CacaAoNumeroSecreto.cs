using System;

public class CacaAoNumeroSecreto {
    public void JogoCacaAoNumeroSecreto(int numeroSecreto){
        
        //Console.WriteLine(aleatorio);
        int chute;

        do {
            Console.Write("Tente adivinhar o numero aleatório de 0 a 100 ou insira -1 para sair: ");
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

        } while(chute != -1);
    }
}