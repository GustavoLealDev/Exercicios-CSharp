using System;
using System.Collections.Generic;

namespace Course
{
     class Employes
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employes(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double SalaryIncrease(double percentage)
        {
            return Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Salary: R$" + Salary.ToString("F2");
        }
    }
}
