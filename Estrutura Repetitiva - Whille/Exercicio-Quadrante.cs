using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {

            int x, y;   

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            while (x !=0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro Quadreante");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else {
                    Console.WriteLine("Quarto Quadrante");
                }
               
                
                Console.WriteLine("Digite novamente o valor X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
    
        }
    }
}
