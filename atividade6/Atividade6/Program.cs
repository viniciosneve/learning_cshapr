/*
Atividade 6: Contagem Regressiva
Crie um programa que faça uma contagem regressiva a partir de um número digitado pelo usuário até zero.

Instruções:

Peça ao usuário para inserir um número positivo.
Use um loop while ou for para exibir uma contagem regressiva.
Quando a contagem chegar a zero, exiba "Fogo!" como se fosse uma contagem para o lançamento de um foguete.
Exemplo de Saída:

css
Copiar código
Digite um número para iniciar a contagem regressiva: 5
5
4
3
2
1
0
Fogo!
*/


using System;

Console.Write("Digite um número para a contagem regresiva: ");
string? str_contagem = Console.ReadLine();
int contagem = int.Parse(str_contagem!);

if (contagem < 0){
    Console.WriteLine("Por favor coloque um número positivo");
} else {
    for (;contagem > 0; contagem--){
        Console.WriteLine(contagem);
    }
    Console.WriteLine("Fogo!");
}