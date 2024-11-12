/*
Atividade 1: Calculadora Simples
Crie um programa que peça ao usuário dois números e uma operação (+, -, *, /). O programa deve então calcular e exibir o resultado da operação.

Instruções:

Use Console.ReadLine() para capturar a entrada dos números e a operação.
Converta as entradas numéricas de string para int ou double.
Implemente a lógica de cada operação (soma, subtração, multiplicação, divisão).
Exiba o resultado da operação.*/


using System;


Console.Write("Escolha o primeiro número: ");
string primeiro_numero = Console.ReadLine();

Console.Write("Escolha o segundo número: ");
string segundo_numero = Console.ReadLine();

int transform_first_number = int.Parse(primeiro_numero);
int transform_second_number = int.Parse(segundo_numero);


Console.WriteLine($"Esse é o resultado da soma dos números: {transform_first_number + transform_second_number}");
Console.WriteLine($"Esse é o resultado da subtração dos números: {transform_first_number - transform_second_number}");
Console.WriteLine($"Esse é o resultado da multiplicação dos números: {transform_first_number * transform_second_number}");
Console.WriteLine($"Esse é o resultado da divisão dos números: {transform_first_number / transform_second_number}");

Console.WriteLine("");
Console.Read();