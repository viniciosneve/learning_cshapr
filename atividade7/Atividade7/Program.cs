/*
Atividade 7: Tabuada de um Número
Escreva um programa que peça ao usuário para digitar um número e, em seguida, exiba a tabuada desse número de 1 a 10.

Instruções:

Peça ao usuário para inserir um número.
Use um loop for para calcular e exibir a multiplicação desse número de 1 a 10.
Exemplo de Saída:

Digite um número para ver a tabuada: 3
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
... 
3 x 10 = 30
*/

using System;

Console.Write("Digite um número que eu irei fazer uma tabuada de 1 a 10: ");
string? str_number = Console.ReadLine();
int number = int.Parse(str_number!);

for (int tabuada = 1; tabuada < 11; tabuada++){
    Console.WriteLine($"{number} X {tabuada} = {number * tabuada}");
}