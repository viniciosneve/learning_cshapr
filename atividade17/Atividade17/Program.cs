/*
Exercício 2: Encapsulamento
Descrição:
Crie uma classe ContaBancaria com os seguintes atributos privados:

saldo (double).
titular (string).
Adicione métodos públicos para:

Exibir o saldo.
Depositar um valor na conta.
Sacar um valor, mas apenas se houver saldo suficiente.
No programa principal:

Crie um objeto da classe ContaBancaria e interaja com os métodos para simular depósitos e saques.
*/
using System;
namespace Banco {
    class ContaBancaria {
        private double saldo = 0;
        private string? titular;

        private string FormatandoValor () {
            string SaldoFormatado = Convert.ToString(saldo);
            char caractereEspecifico = ',';
            int QuantidadeCaracteres = 0;
            if (SaldoFormatado.Contains(caractereEspecifico)){
                QuantidadeCaracteres = SaldoFormatado.IndexOf(caractereEspecifico)-1;
            } else {
                QuantidadeCaracteres = SaldoFormatado.Length-1;
            }

            if (QuantidadeCaracteres > 2) {
                int Contagem = 0;
                for (;QuantidadeCaracteres > 0; QuantidadeCaracteres--){
                    Contagem++;
                    if (Contagem == 3) {
                        SaldoFormatado = SaldoFormatado.Insert(QuantidadeCaracteres, ".");
                        Contagem = 0;
                    }
                }
            }
            return SaldoFormatado;
        }
        public void ShowSaldo () {
            Console.WriteLine($"O seu saldo bancario é de: R${FormatandoValor()}");
        }
        public void Deposit () {
            bool RunningLoopingDeposit = true;
            while (RunningLoopingDeposit == true) {
                try{
                    Console.Write($"Quanto que você quer depositar? ");
                    string Deposito = Console.ReadLine();
                    double DepositoPronto = double.Parse(Deposito);
                    saldo += DepositoPronto;
                    Console.WriteLine($"Deposito feito com sucesso!!!");
                    RunningLoopingDeposit = false;
                } catch (FormatException) {
                    Console.WriteLine("Por favor digite apenas a quantia que você deseja depositar!!!");
                }
            }
        }
        public void WithdrawValue () {
            bool RunningLoopingRetirada = true;
            while (RunningLoopingRetirada == true) {
                try{
                    if (saldo > 0) {
                        Console.Write($"O seu valor é de R${FormatandoValor()} quanto que você quer retirar? ");
                        string Retirada = Console.ReadLine();
                        double RetiradaPronto = double.Parse(Retirada);
                        if (RetiradaPronto < saldo) {
                            saldo -= RetiradaPronto;
                            Console.WriteLine($"Retirada feito com sucesso!!!");
                            RunningLoopingRetirada = false;
                            return;
                        }
                        Console.WriteLine("!!!Você selecionou um valor muito superior a que você tem!!!");
                    } else {

                        Console.WriteLine("Você não tem nenhum valor para ser retirado");
                        RunningLoopingRetirada = false;
                    }
                    
                } catch (FormatException) {
                    Console.WriteLine("Por favor digite apenas a quantia que você deseja retirar!!!");
                }
            }
        }
        public void GettingTitular () {
            while (true) {
                Console.Write("Digite o seu nome completo para identifica-lo:\n>>>");
                string Nome = Console.ReadLine().Trim();

                if (Nome != "") {
                    Console.Write($"Você tem certeza de que '{Nome}' é o seu nome?\n[S] sim\n[N] não\n>>> ");
                    string Confirmacao = Console.ReadLine().ToUpper();

                    if (Confirmacao == "S") {
                        titular = Nome;
                        return;
                    }
                }
            }
        }
    }

    class Caixa () {
        static void Main(string[] args){
            ContaBancaria caixa = new ContaBancaria();
            bool RunningLoopingCaixa = true;

            while (RunningLoopingCaixa == true) {
                Console.Write("Olá o que você deseja?\n[0] Sair\n[1] Ver saldo\n[2] Depositar\n[3] Retirar\n>>> ");
                string input = Console.ReadLine();

                if (input == "0") {
                    Console.WriteLine("Saindo...");
                    RunningLoopingCaixa = false;
                } else if (input == "1") {
                    caixa.ShowSaldo();
                } else if (input == "2") {
                    caixa.Deposit();
                } else if (input == "3") {
                    caixa.WithdrawValue();
                } else {
                    Console.WriteLine("Essa opção não existe por favor tenta uma das opções mencionado a cima");
                }
            }
        }
    }
}