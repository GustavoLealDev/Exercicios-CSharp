using System;
using System.Globalization;

    class course {
      class Program {
        static void Main(string[] args) {

            Console.Write("Digite o número para saber se é impar ou par: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine($"{x} é par");
            } else {
                Console.WriteLine($"{x} é impar");
            }
        }
    }
}