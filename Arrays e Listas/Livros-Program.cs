using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livros> list = new List<Livros>();

            int opcao;
            do
            {
                Console.WriteLine("Sistema de Cadastro de Livros");
                Console.WriteLine("1. Cadastrar livro"); 
                Console.WriteLine("2. Livros a disposição");
                Console.WriteLine("3. Exclua um livro");
                Console.WriteLine("4. Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        int anoDePublicacao = int.Parse(Console.ReadLine());
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        list.Add(new Livros(titulo, autor, anoDePublicacao, preco));
                        break;

        } 
    }
}

