using System;
using System.Collections.Generic;

namespace Course
{
     class Funcionarios
    {
        public string Name { get; set; }    
        public double Salary { get; set; }

        public Funcionarios(string name, double salary) { 
            Name = name;
            Salary = salary;
        }

        public override string ToString() { 
            return "Funcionário: " + Name + ", Tem o salário de: R$" + Salary;  
        }

    }
}
