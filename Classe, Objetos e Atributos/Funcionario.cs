using System;
using System.Collections.Generic;

namespace Course
{
     class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
           return  SalarioBruto - Imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto += SalarioBruto * porcentagem / 100;
        }

        public override string ToString() { 
            return "Funcionário: " + Nome + ", R$" + SalarioLiquido().ToString("F2");
        }
    }
}
