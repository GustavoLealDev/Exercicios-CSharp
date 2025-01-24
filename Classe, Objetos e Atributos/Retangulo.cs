using System;
using System.Collections.Generic;

namespace Course
{
     class Retangulo
    {
        public double Base;
        public double Altura;

        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }


    }
}
