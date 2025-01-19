using System;
using System.Globalization;

class course {
      class Program {
        static void Main(string[] args) {

            Console.WriteLine("1 | CACHORRO QUENTE | R4.00");
            Console.WriteLine("2 |    X-SALADA     | R4.50");
            Console.WriteLine("3 |    X-BACON      | R5.00");
            Console.WriteLine("4 | TORRADA SIMPLES | R2.00");
            Console.WriteLine("5 |  REFRIGERANTE   | R1.50");
           
            Console.WriteLine();
            
            Console.Write("Informe o código do pedido: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int b = int.Parse(Console.ReadLine());

            
            double total = 0;

            if (a == 1) {
                total = b * 4.0;
            }
            else if (a == 2) {
                total = b * 4.5;
            }
            else if (a == 3) {
                total = b * 5.0;
            }
            else if (a == 4) {
                total = b * 2.0;
            }
            else {
                total = b * 1.5;
            }

            Console.WriteLine($"TOTAL: R${total.ToString("F2")}");

        }
    }
}