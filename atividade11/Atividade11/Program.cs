/*
Atividade 11: Calculadora com Métodos
Crie uma calculadora básica que usa métodos para realizar as operações matemáticas: soma, subtração, multiplicação e divisão.

Requisitos:

Crie métodos estáticos separados para cada operação matemática.
O programa deve solicitar dois números e uma operação ao usuário.
Mostre o resultado da operação.
Exemplo de execução:


Digite o primeiro número: 10
Digite o segundo número: 2
Escolha a operação (+, -, *, /): *
Resultado: 20
*/

using System;
using System.Security.Cryptography;
class Calculadora{
    public static double Soma(double primeiro_numero, double segundo_numero){
        double resultado_soma = primeiro_numero + segundo_numero;
        return resultado_soma;
    }

    public static double Subtracao(double primeiro_numero, double segundo_numero){
        double resultado_subtracao = primeiro_numero - segundo_numero;
        return resultado_subtracao;
    }

    public static double Divisao(double primeiro_numero, double segundo_numero){
        double resultado_divisao = primeiro_numero / segundo_numero;
        return resultado_divisao;
    }

    public static double Multiplicacao(double primeiro_numero, double segundo_numero){
        double resultado_multiplicacao = primeiro_numero * segundo_numero;
        return resultado_multiplicacao;
    }
}

class Program {
    static void Main() {
        try {
            Console.WriteLine("Por favor passe os valores e o operador matemático para fazer a operação");

            Console.Write("Primeiro número:  ");
            string? str_primeiro_numero = Console.ReadLine();
            double primeiro_numero = double.Parse(str_primeiro_numero!);

            Console.Write("Segundo número: ");
            string? str_segundo_numero = Console.ReadLine();
            double segundo_numero = double.Parse(str_segundo_numero!);

            Console.Write("Operador aritimetico (+, -, *, /): ");
            string? operador_aritimetico = Console.ReadLine();

            if (operador_aritimetico == "+") {
                double fazendo_soma = Calculadora.Soma(primeiro_numero, segundo_numero);

                Console.WriteLine($"A soma dos números é: {fazendo_soma}");

            } else if (operador_aritimetico == "-") {
                double fazendo_subtracao = Calculadora.Subtracao(primeiro_numero, segundo_numero);

                Console.WriteLine($"A subtração dos números é: {fazendo_subtracao}");

            } else if (operador_aritimetico == "*") {
                double fazendo_multiplicacao = Calculadora.Multiplicacao(primeiro_numero, segundo_numero);

                Console.WriteLine($"A multiplicação dos números é: {fazendo_multiplicacao}");

            } else if (operador_aritimetico == "/") {
                double fazendo_divisao = Calculadora.Divisao(primeiro_numero, segundo_numero);

                Console.WriteLine($"A divisão dos números é: {fazendo_divisao}");

            } else {
                Console.WriteLine("Esse caractere não é válido");
            }
        } catch (FormatException) {
            Console.WriteLine("Por favor digite um número e não coloque nenhuma outra caractere diferente a menos que queira representar um número negativo");
        }
    }
}