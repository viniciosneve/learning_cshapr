/*
Atividade 13: Validação de Entrada com Função
Crie um método que valide se a entrada do usuário é um número válido. Use esse método para solicitar um número até que o usuário insira um valor correto.

Requisitos:

Se o valor não for um número, o método deve retornar uma mensagem de erro e pedir outro valor.
Após validar, mostre se o número é par ou ímpar usando um método.
Exemplo de execução:


Digite um número: abc
Entrada inválida. Digite um número válido: 10
O número 10 é par.
*/

using System;
bool loopRunnig = true;
while (loopRunnig == true){
    try{
        Console.Write("Digite um número (ou digite sair para finalizar): ");
        string? input = Console.ReadLine();
        if (input == "sair"){
            loopRunnig = false;
            continue;
        }

        double numero = double.Parse(input!);

        string mensagem = $"O número {numero} é ";

        if (numero % 2 == 0){
            Console.WriteLine(mensagem+"par");
        } else {
            Console.WriteLine(mensagem+"ímpar");
        }

    }catch (FormatException) {
        Console.WriteLine("Entrada inválida");
    }

}
