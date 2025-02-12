using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (I/C)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(ic == 'i' || ic == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new IndividualTax(healthExpenditures, name, anualIncome));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());   
                    list.Add(new CompanyTax(employees, name, anualIncome));
                    Console.WriteLine();
                }
            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer pessoa in list)
            {
                double tax = pessoa.Tax();
                Console.WriteLine(pessoa.Name + ": $ " + tax.ToString("F2"));
                sum += tax;
            }
           
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXE: " + sum.ToString("F2"));
        }
    }
}