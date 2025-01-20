using System;
using System.Globalization;

class course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o sálario para saber o imposto de renda: ");
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0;

            if (salario >= 0 && salario <= 2000.0) {
                Console.WriteLine($"{salario} é isento de impostos!!");
            }
            else if (salario <= 3000.0) {
                imposto = ((salario - 2000.0) * 0.08);
                Console.WriteLine($"O imposto de {salario} é : {imposto}");
            }
            else if (salario <= 4500.0) {
                imposto = ((salario - 3000.0) * 0.18) + (1000.0 * 0.08);
                Console.WriteLine($"O imposto de {salario} é : {imposto}");
            }
            else if (salario > 4500.0) {
                imposto = ((salario - 4500.0) * 0.28) + (1500.0 * 0.18) + (1000 * 0.08);
                Console.WriteLine($"O imposto de {salario} é : {imposto}");
            }

        }
    }
}