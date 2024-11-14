/*
Atividade 9: Somador de Números
Crie um programa que permita ao usuário inserir números continuamente até que ele digite 0. O programa deve somar todos os números inseridos e exibir o total ao final.

Instruções:

Use um loop do-while para continuar pedindo ao usuário que insira um número.
Some cada número à medida que ele é inserido.
O loop deve parar quando o usuário inserir 0.
Exiba o total da soma ao final.
Exemplo de Saída:


Digite um número (ou 0 para terminar): 5
Digite um número (ou 0 para terminar): 3
Digite um número (ou 0 para terminar): 7
Digite um número (ou 0 para terminar): 0
A soma total é: 15
*/

using System;
Console.WriteLine("Digite um número (ou 0 para terminar) irei somar todos");
int number = 0;
int ResultSoma = 0;
do {
    Console.Write("> ");
    string? str_number = Console.ReadLine();
    int number_selected = int.Parse(str_number!);
    ResultSoma += number_selected;
    number = number_selected;
} while (number != 0);

Console.WriteLine("A soma total de todos os númneros é " + ResultSoma);