/*
Exercício 1: Classes e Objetos
Descrição:
Crie uma classe chamada Livro com os seguintes atributos: título, autor e número de páginas. Adicione um método para exibir as informações do livro.
No programa principal:

Crie dois objetos da classe Livro.
Exiba as informações de cada livro chamando o método.
*/

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Livro {
    public string? Titulo {get; set;}
    public string? Autor {get; set;}
    public int Paginas {get; set;}

    private List<List<string>> Pratelheiras = new List<List<string>>();

    public void RegistrandoLivro () {
        List<string> livro = [];
        livro.Add(Titulo!);
        livro.Add(Autor!);
        livro.Add(Convert.ToString(Paginas));

        Pratelheiras.Add(livro);
    }

    public void ShowPratelheiras() {
        if (Pratelheiras.Count == 0) {
            Console.WriteLine("Nenhum livro registrado.");
            return;
        }

        for (int i = 0; i < Pratelheiras.Count; i++) {
            var livro = Pratelheiras[i];
            Console.WriteLine("==============================\n");
            Console.WriteLine($"Livro {i + 1}:");
            Console.WriteLine($"Título: {livro[0]}");
            Console.WriteLine($"Autor: {livro[1]}");
            Console.WriteLine($"Páginas: {livro[2]}\n");
            Console.WriteLine("==============================");
        }
    }

    public void InformacoesDoLivro () {
        RegistrandoLivro();

        Console.WriteLine($"Titulo do livro: {Titulo}\nAutor do livro: {Autor}\nPáginas: {Paginas}");
    }
}


class Programa {
    public static void Main (string[] args) {
        ExecutionAll();
    }

    static void EnviandoLivro (Livro livro) {
        livro.RegistrandoLivro();
    }

    static List<string> GetInformationFromBook () {
        List<string> InformationOfBook = new List<string>();
        Console.Write("Por favor me passe as informações do livro\nTitulo: ");
        string? TitleOfBook = Console.ReadLine();
        Console.Write("Autor: ");
        string? authorOfBook = Console.ReadLine();
        Console.Write("Páginas: ");
        string? PagesOfBook = Console.ReadLine();

        InformationOfBook.Add(TitleOfBook!);
        InformationOfBook.Add(authorOfBook!);
        InformationOfBook.Add(PagesOfBook!);

        return InformationOfBook;
    }

    static void ExecutionAll () {
        bool looping = true;
        Livro Biblioteca = new Livro();
        while(looping == true) {
            Console.Write("O que você deseja?\n[0] Sair\n[1]Ver livros\n[2]Registrar um livro\n>>> ");
            string? Answer = Console.ReadLine();
            if (Answer == "0") {
                looping = false;
            } else if (Answer == "1") {
                Biblioteca.ShowPratelheiras();
            } else if (Answer == "2") {
                try{
                    List<string> InfoOfBook = GetInformationFromBook();
                    Biblioteca.Titulo = InfoOfBook[0];
                    Biblioteca.Autor = InfoOfBook[1];
                    Biblioteca.Paginas = int.Parse(InfoOfBook[2]);
                    EnviandoLivro(Biblioteca);
                } catch (FormatException) {
                    Console.WriteLine("Por favor coloque um número inteiro, sem letras, sem pontos, sem virgulas e sem caracteres especiais");
                }
            } else {
                Console.WriteLine("Essa opção não existe por favor digite um dos números mencionados");
            }
        }
    }
}