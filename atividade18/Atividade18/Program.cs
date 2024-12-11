/*
Exercício 3: Herança
Descrição:
Crie uma classe base Funcionario com os atributos:

Nome (string)
Salario (double)
E um método para exibir as informações do funcionário.

Depois, crie duas classes derivadas:

Gerente: que tenha um método adicional para exibir o bônus de R$ 2.000.
Programador: que tenha um método adicional para exibir o valor de um bônus de R$ 1.000.
No programa principal:

Crie um objeto de cada classe derivada e exiba as informações de cada funcionário.
*/

using System;

namespace Empresa {
    class Funcionarios{
        public string? Nome {get; set;}
        public double Salario {get; set;}

        public void InformationDeployeer () {
            Console.WriteLine("==============================");
            Console.WriteLine($"\nNome do funcionário: {Nome}\nSalario do funcinário: {Salario} + Bonus");
        }
    }

    class Gerente : Funcionarios {
        public void ShowInformationGerente () {
            InformationDeployeer();
            Console.WriteLine("O gerente recebe um bonús de R$2.000\n");
            Console.WriteLine("==============================");
        }
    }

    class Programador : Funcionarios {
        public void ShowInformationDev () {
            InformationDeployeer();
            Console.WriteLine("O programador recebe um bonús de R$1.000\n");
            Console.WriteLine("==============================");
        }
    }

    class Programa {
        static void Main (string[] args) {
            Gerente Gerente_Iniciante = new Gerente(){Nome = "Antônio dos Santos", Salario = 2500};
            Gerente Gerente_Mestre = new Gerente(){Nome = "Carlos Gonsalves da Costa", Salario = 3200};

            Programador Programador_Junior = new Programador(){Nome= "José Martins Machado", Salario = 1700};
            Programador Programador_Senior = new Programador(){Nome= "Marcos da Silva", Salario= 4100};
            Programador Teck_lider = new Programador(){Nome= "Vinicios da Silva Neves", Salario= 5300};

            Gerente_Mestre.ShowInformationGerente();
            Teck_lider.ShowInformationDev();
            Gerente_Iniciante.ShowInformationGerente();
            Programador_Senior.ShowInformationDev();
            Programador_Junior.ShowInformationDev();
        }
    }
}