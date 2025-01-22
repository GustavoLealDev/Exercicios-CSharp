using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();
            
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());



            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Name} é mais velho(a)");
            }
            else {
                Console.WriteLine($"{p2.Name} é mais velho(a)");
            }
        }
    }
}
