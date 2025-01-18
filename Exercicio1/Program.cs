using System;
using System.Globalization;

    class course {
      class Program {
        static void Main(string[] args) {

            
            Console.WriteLine("Digite o número para saber se é Positivo ou Negativo: ");
            int numero = int.Parse(Console.ReadLine());
            
            while (numero != 2002) {
                Console.WriteLine("Senha incorreta! Tente Novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("ACESSO PERMITIDO!!");
        }
    }
}