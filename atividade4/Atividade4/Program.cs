/*
Atividade 4: Calculador de Média
Desenvolva um programa que calcule a média de três notas fornecidas pelo usuário.

Instruções:

Peça ao usuário para inserir três notas.
Calcule a média.
Exiba a média e informe se o aluno foi aprovado (média maior ou igual a 7) ou reprovado.
Exemplo de Saída:

less
Copiar código
Digite a primeira nota: 6
Digite a segunda nota: 7
Digite a terceira nota: 8
Média: 7
Você foi aprovado.
*/

using System;

Console.Write("Digite a sua primeira nota: ");
string str_primeira_nota = Console.ReadLine();

Console.Write("Digite a sua segunda nota: ");
string str_segunda_nota = Console.ReadLine();

Console.Write("Digite a sua terceira nota: ");
string str_terceira_nota = Console.ReadLine();

int primeira_nota = int.Parse(str_primeira_nota);
int segunda_nota = int.Parse(str_segunda_nota);
int terceira_nota = int.Parse(str_terceira_nota);

if (primeira_nota + segunda_nota + terceira_nota >= 7){
    Console.WriteLine("Parabéns você conseguiu passar");
} else {
    Console.WriteLine("Infelizmente as suas notas não foram o suficiente para passar");
}