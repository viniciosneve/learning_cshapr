/*
Atividade 5: Adivinhação de Números
Crie um jogo simples onde o programa escolhe um número aleatório entre 1 e 20, e o usuário tenta adivinhar o número. O jogo continua até que o usuário acerte.

Instruções:

Gere um número aleatório entre 1 e 20 usando a classe Random.
Use um loop while para permitir que o usuário continue tentando até adivinhar o número.
Dê dicas ao usuário informando se o palpite está "muito alto" ou "muito baixo".
Quando o usuário acertar, exiba uma mensagem de parabéns e termine o loop.
Exemplo de Saída:

Estou pensando em um número entre 1 e 20. Tente adivinhar!
Seu palpite: 10
Muito alto!
Seu palpite: 5
Muito baixo!
Seu palpite: 7
Parabéns! Você adivinhou o número.
*/
using System;
Random random = new Random();

int numeroAleatorio = random.Next(1, 21);
bool acerto = false;

Console.WriteLine("Estou pensando em um número entre 1 e 20. Tente adivinhar!");
while(acerto != true){
    Console.Write("Seu palpite: ");
    string? str_palpite = Console.ReadLine();
    int palpite = int.Parse(str_palpite!);

    if (palpite == numeroAleatorio){
        Console.WriteLine("Parabéns! Você adivinhou o número.");
        acerto = true;
    } else if (palpite > numeroAleatorio){
        Console.WriteLine("Muito alto!");
    } else {
        Console.WriteLine("Muito baixo!");
    }
}