using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario(); 
            
            Console.WriteLine("DIGITE OS DADOS DO FUNCIONARIO: ");
            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(F);
            Console.WriteLine();
            Console.WriteLine("Digite a porcentageem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            F.AumentarSalario(porcentagem);

            Console.WriteLine(F);
        }
    }
}
