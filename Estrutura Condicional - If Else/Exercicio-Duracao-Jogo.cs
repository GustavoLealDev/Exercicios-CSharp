using System;
using System.Globalization;

class course {
      class Program {
        static void Main(string[] args) {

            Console.Write("Digite a hora que começou o jogo: ");
            int HoraI = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora em que acabou o jogo ");
            int HoraF = int.Parse(Console.ReadLine());

            int Duracao = 24;

            if (HoraI > HoraF) {
                Duracao = (24 - HoraI + HoraF);

            } else if (HoraF > HoraI){
                Duracao = HoraF - HoraI;
            }

            Console.WriteLine($"O Jogo durou {Duracao}");

        }
    }
}