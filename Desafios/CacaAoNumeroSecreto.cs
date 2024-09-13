using System;

public class CacaAoNumeroSecreto {
    public void JogoCacaAoNumeroSecreto(int aleatorio){
        
        Console.WriteLine(aleatorio);
        int numero;

        do {
            Console.Write("Tente adivinhar o numero aleatório ou insira -1 para sair: ");
            numero = int.Parse(Console.ReadLine()!);

            if(numero != -1){
                if(numero == aleatorio){
                    Console.WriteLine("Parabéns você acertou!");
                    break;
                } else {
                    Console.WriteLine("Não é esse numero, tente novamente!");
                }
            }

        } while(numero != -1);
    }
}