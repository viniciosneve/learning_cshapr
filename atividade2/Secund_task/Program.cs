/*
Atividade 2: Identificador de Par ou Ímpar
Desenvolva um programa que identifique se um número fornecido pelo usuário é par ou ímpar.

Instruções:

Peça ao usuário para digitar um número.
Verifique se o número é par ou ímpar usando o operador de módulo (%).
Exiba uma mensagem indicando se o número é par ou ímpar.
Exemplo de Saída:

Copiar código
Digite um número: 7
O número é ímpar.
*/

using System;

Console.Write("Digite um número e lhe direi se o mesmo é ímpar ou par: ");
string number_selected = Console.ReadLine();

int transform_number = int.Parse(number_selected);

string tipo = "";

if (transform_number % 2 == 0) {
    tipo = "par";
} else {
    tipo = "ímpar";
}

Console.WriteLine($"O número que você escolheu foi o número: {transform_number} e esse numero é {tipo}");