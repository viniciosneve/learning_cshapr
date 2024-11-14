/*
Atividade 8: Verificador de Números Pares
Desenvolva um programa que exiba todos os números pares de 1 até um número limite definido pelo usuário.

Instruções:

Peça ao usuário para inserir um número limite.
Use um loop for ou while para verificar e exibir todos os números pares de 1 até o limite.
Exemplo de Saída:

Digite o número limite: 10
2
4
6
8
10
*/

using System;
Console.Write("Digite um número que eu vou dizer quais são pares de 1 ao número que você escolheu: ");
string? str_number_selcted = Console.ReadLine();
int number_selected = int.Parse(str_number_selcted!);

Console.WriteLine("Os números pares são:");
for (int initial_number = 1; initial_number < number_selected+1; initial_number++){
    if (initial_number % 2 == 0){
        Console.WriteLine(initial_number);
    }
}