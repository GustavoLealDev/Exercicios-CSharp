using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Projetos\in.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}