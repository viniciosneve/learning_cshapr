/*
Atividade 3: Verificador de Idade para Maioridade
Escreva um programa que peça ao usuário a idade e diga se ele é maior de idade (18 anos ou mais).

Instruções:

Peça ao usuário para digitar sua idade.
Verifique se a idade é maior ou igual a 18.
Exiba uma mensagem informando se a pessoa é maior ou menor de idade.
Exemplo de Saída:

yaml
Copiar código
Digite sua idade: 20
Você é maior de idade.
*/

using System;

Console.Write("Qual é a sua idade para verifcar se você pode entrar: ");
string Str_idade = Console.ReadLine();

int idade_usuario = int.Parse(Str_idade);

if (idade_usuario >= 18) {
    Console.WriteLine("Você é maior de idade, então você tem acesso");
} else if (idade_usuario < 0) {
    Console.WriteLine("Por favor coleque a sua idade.");
} else if (idade_usuario < 18) {
    Console.WriteLine("Você não é maior de idade, então você não tem acesso");
}