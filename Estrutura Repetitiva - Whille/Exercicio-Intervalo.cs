using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite quantos números você ira digitar: ");
            int N = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20) { 
                    dentro = dentro + 1;
                } else {
                    fora = fora + 1;  
                }
            }

            Console.WriteLine($"{dentro} estão DENTRO");
            Console.WriteLine($"{fora} estão FORA!!");

        }
    }
}