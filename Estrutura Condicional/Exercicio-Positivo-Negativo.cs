using System;
using System.Globalization;

    class course {
      class Program {
        static void Main(string[] args) {

            Console.Write("Digite o número para saber se é Positivo ou Negativo: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 0 ){
                Console.WriteLine($"{numero} é Positivo!!");
            } else {
                Console.WriteLine($"{numero} é Negativo!!");
            }

            
        }
    }
}