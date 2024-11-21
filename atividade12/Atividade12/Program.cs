/*
Atividade 2: Jogo da Tabuada
Implemente um programa que:

Solicite um número ao usuário.
Use um método para calcular e exibir a tabuada completa desse número (de 1 a 10).
Desafio adicional: Use um loop para permitir que o usuário escolha outros números até que digite "sair".

Exemplo de execução:


Digite um número para ver a tabuada: 5
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50
Digite outro número ou "sair" para encerrar: sair
*/
using System;

bool continuarLooping = true;

while (continuarLooping == true) {
    try{
        Console.Write("Digite um número que eu irei mostra a tabuada de 1 a 10 (ou digite sair para finalizar): ");
        string? str_numero = Console.ReadLine();

        if (str_numero == "sair") {
            continuarLooping = false;
        }

        double numero = double.Parse(str_numero!);
        Console.WriteLine($"Esse é a tabuada do número {numero}");

        for (int i = 1; i < 11; i++){
            Console.WriteLine($"{numero} X {i} = {numero * i}");
        }
        
    } catch (FormatException){
        Console.WriteLine("Por favor coloque um numero positivo ou negativo");
    }
}