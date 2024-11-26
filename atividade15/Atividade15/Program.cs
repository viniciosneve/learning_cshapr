/*
Atividade 15: Estatísticas de Números
Crie um programa que:

Solicite uma lista de números ao usuário (separados por espaço).
Use funções para:
Calcular a soma dos números.
Encontrar o maior e o menor número.
Determinar a média dos números.
Exemplo de execução:

Digite uma lista de números separados por espaço: 10 20 30 40 50
Soma: 150
Maior número: 50
Menor número: 10
Média: 30
Dica: Use string.Split() para dividir os números e loops para processá-los.
*/

using System;

try{
    Console.Write("Digite uma lista de números separados por espaços: ");
    string? input = Console.ReadLine();

    string[] partes = input.Split(' ');

    double soma_total = 0;
    double menor_numero = 0;
    double maior_numero = 0;
    double quantidades_numeros_na_ordem = 0;

    bool primeiro_numero = false;

    foreach(string parte in partes){
        double numero = double.Parse(parte);
        soma_total += numero;
        if (primeiro_numero == false){
            menor_numero = numero;
            maior_numero = numero;
            primeiro_numero = true;
        }
        if (menor_numero > numero){
            menor_numero = numero;
        }
        if (maior_numero < numero){
            maior_numero = numero;
        }
        quantidades_numeros_na_ordem++;
    }

    Console.WriteLine($"A soma de todos os números é: {soma_total}");
    Console.WriteLine($"O menor número é: {menor_numero}");
    Console.WriteLine($"O maior número é: {maior_numero}");
    Console.WriteLine($"A média é: {soma_total / quantidades_numeros_na_ordem}");

} catch(FormatException){
    Console.WriteLine("Por favor digite apenas números positivos ou negativos");
}