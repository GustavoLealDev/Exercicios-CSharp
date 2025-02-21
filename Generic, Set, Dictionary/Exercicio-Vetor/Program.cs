using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Value {i}: ");
                int x = int.Parse(Console.ReadLine());  
                printService.AddValue(x);
            }

            Console.WriteLine("First Value: " + printService.First());
            Console.WriteLine("Max Value: " + printService.Max());
        }
    }
}