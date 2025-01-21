using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Digite o número para saber os ímpares: ");
            int x = int.Parse(Console.ReadLine());

                for (int i = 1; i <= x; i++) {
                   if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
