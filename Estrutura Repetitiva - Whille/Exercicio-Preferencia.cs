using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("1 | ÁLCOOL");
            Console.WriteLine("2 | GASOLINA");
            Console.WriteLine("3 | DIESEL");
            Console.WriteLine("4 | FIM ");

            Console.WriteLine();

            Console.Write("Qual tipo de combustível você tem preferência: ");
            int pref = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            while (pref != 4) {
                if (pref == 1) {
                    alcool = alcool + 1;
                    Console.WriteLine();
                }
                else if (pref == 2) {
                    gasolina = gasolina + 1;
                    Console.WriteLine();
                }
                else if (pref == 3) {
                    diesel = diesel + 1; 
                    Console.WriteLine(); 
                }
                Console.WriteLine("Digete outro tipo: ");
                pref = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("MUITO OBRIGADO!!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        
        
        
        }
    }
}