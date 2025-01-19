using System;
using System.Globalization;

class course {
      class Program {
        static void Main(string[] args) {

            double x, y;

            Console.Write("Digite o valor de x: ");
            x = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor de y: ");
            y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } 
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } 
            else if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }

        }
    }
}