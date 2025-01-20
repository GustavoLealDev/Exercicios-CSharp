using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite uma senha para sua conta: ");
            int senhaC = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite ume senha válida para entrar no sistema: ");
            int senhaT = int.Parse(Console.ReadLine());

            while (senhaT != senhaC) {
                Console.WriteLine("SENHA OU EMAIL INVÁLIDA(o)!!");
                Console.WriteLine();
                Console.WriteLine("Tente novamente: ");
                senhaT = int.Parse (Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("ACESSO PERMITIDO!!");

        }
    }
}

  