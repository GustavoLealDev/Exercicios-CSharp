using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1]);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();   
             Product Max = calculationService.Max(list);

            Console.WriteLine("Max value: " + Max);
        }
    }
}