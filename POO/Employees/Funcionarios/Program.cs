using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (Y/N)? ");
                string yn = Console.ReadLine();
                if(yn == "Y" ||  yn == "y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    OutsourcedEmployee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(employee);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                    Console.WriteLine();
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees) 
            {
                Console.WriteLine(employee);
            }
        
        }
    }
}