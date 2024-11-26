/*
Atividade 4: Jogo de Adivinhação com Função
Melhore o jogo de adivinhação que você já fez, mas agora divida a lógica em funções.

Requisitos:

Crie um método para gerar um número aleatório.
Crie um método para processar o palpite do usuário (retornar "Muito alto!", "Muito baixo!" ou "Acertou!").
Use um loop para permitir várias tentativas.
Exemplo de execução:


Estou pensando em um número entre 1 e 20. Tente adivinhar!
Seu palpite: 15
Muito alto!
Seu palpite: 10
Muito baixo!
Seu palpite: 12
Parabéns! Você adivinhou o número.
*/

using System;

class Sistema {
    public static int NumeroAleatorio(int primeiroNumero, int segundoNumero) {
        Random random = new Random();
        int numeroAleatorio = random.Next(primeiroNumero, segundoNumero);
        return numeroAleatorio;
    }

    public static double SaidaUsuario () {
        Console.Write("Por favor tente adivinhar um número de 1 a 10(digite o número '0' para finalizar'): ");
        string? input = Console.ReadLine();
        double numeroSelected = double.Parse(input!);
        return numeroSelected;
    }

    public static void ProcurandoNumero(double numero, int numeroRandom, ref bool looping){
        if (numero > numeroRandom){
            Console.WriteLine("Muito alto!");
        } else if (numero < numeroRandom){
            Console.WriteLine("Muito baixo!");
        } else {
            Console.WriteLine("Parabêns você acertou");
            looping = false;
        }
    }

}


class Program {
    static void Main (){
        bool looping = true;
        int numeroRandom = Sistema.NumeroAleatorio(1, 11);
        while (looping == true){
            try {
                double numero = Sistema.SaidaUsuario();
                if (numero == 0){
                    looping = false;
                    continue;
                }

                Sistema.ProcurandoNumero(numero, numeroRandom, ref looping);
                
            } catch (FormatException) {
                Console.WriteLine("Por favor digite um número");
            }
            
        }
        
    }
    
}