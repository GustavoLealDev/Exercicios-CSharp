using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vet = new Quartos[10];

            Console.Write("Quantos quartos você ira alugar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine($"Aluguel {i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Quartos(nome,email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos Alugados: ");
            for (int i = 1; i <= 10; i++) {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
                
            }

        }
    }
}