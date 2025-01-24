using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> list = new List<Funcionarios>();
            
            Console.Write("Quantos funcionários você quer cadastrar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine($"Dados do funcionario #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine());
                Funcionarios p = new Funcionarios(name, salary);
                list.Add(p);
                Console.WriteLine();
            }

            foreach (Funcionarios obj in list) {
                Console.WriteLine(obj);
            }

            double soma = 0;
            foreach (Funcionarios obj in list) {
                soma += obj.Salary;
            }
            double media = soma / list.Count;

            Console.WriteLine($"Media salarial: R${media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}