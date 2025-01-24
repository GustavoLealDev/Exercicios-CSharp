using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Entre com a Base e Altura do Retângulo: ");
            retangulo.Base = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}
