using System;
using System.Globalization;

    class course {
      class Program {
        static void Main(string[] args) {

            Console.Write("Digite dois números para saber se são multiplos: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int multi = a + b;

            if (multi % 2 == 0) {
                Console.WriteLine($"{a} e {b} São multiplos!!");
            }
            else {
                Console.WriteLine($"{a} e {b} Não são multiplos!!");
            }
         
        }
    }
}