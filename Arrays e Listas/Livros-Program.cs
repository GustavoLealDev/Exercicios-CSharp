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
                Console.WriteLine("1 - Cadastre um livro"); 
                Console.WriteLine("2 - Livros a disposição");
                Console.WriteLine("3 - Exclua um livro");
                Console.WriteLine("4 - Sair do Sistema");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        
                        Console.Write("Nome do Livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        int anoDePublicacao = int.Parse(Console.ReadLine());
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        list.Add(new Livros(titulo, autor, anoDePublicacao, preco));
                        break;

                    case 2:
                        
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Nenhum livro cadastrado.");
                        }
                        else
                        {
                            foreach (Livros livro in list)
                            {
                                Console.WriteLine(livro);
                            }
                        }
                        break;

        } 
    }
}

