using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employes> list = new List<Employes>();

            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee {i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employes(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employes emp = list.Find(x =>  x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.SalaryIncrease(percentage);
            }
            else {
                Console.Write("This ID no exist!!");
            }

                Console.WriteLine("Update list of Employees: ");
            foreach (Employes obj in list) {
                Console.WriteLine(obj);
            }
         
        }
    }
}
