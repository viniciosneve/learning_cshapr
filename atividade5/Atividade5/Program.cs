/*

Atividade 5: Programa de Saudações
Crie um programa que pergunte o nome e a hora do dia para dar uma saudação personalizada.

Instruções:

Peça o nome do usuário.
Pergunte a hora atual (apenas o número, por exemplo, 10 para 10 da manhã).
Exiba uma saudação de acordo com o horário (ex: "Bom dia", "Boa tarde", "Boa noite") e o nome.
Exemplo de Saída:

Qual o seu nome? Maria
Que horas são? 15
Olá, Maria! Boa tarde.
Essas atividades devem ajudar você a praticar bastante os conceitos já estudados!

*/

using System;

Console.Write("Qual é o seu nome: ");
string nome_usuario = Console.ReadLine();

Console.Write("Que horas são (por favor colocar apenas a hora): ");
string str_horario = Console.ReadLine();

int horario = int.Parse(str_horario);

if (horario > 23 || horario < 0) {
    Console.WriteLine("Por favor coloque a hora certa");
} else if (horario >= 19) {
    Console.WriteLine($"Olá, {nome_usuario}! Boa noite");
} else if (horario >= 12) {
    Console.WriteLine($"Olá, {nome_usuario}! Boa tarde");
} else if (horario >= 5) {
    Console.WriteLine($"Olá, {nome_usuario}! Bom dia");
} else if (horario >= 0) {
    Console.WriteLine($"Olá, {nome_usuario}! Boa madrugada");
} 