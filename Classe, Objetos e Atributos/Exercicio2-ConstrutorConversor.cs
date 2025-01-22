using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você ira comprar? ");
            double cotacao = double.Parse(Console.ReadLine());  

            double Total = ConversoDeMoedas.Conversor(dolar, cotacao);

            Console.WriteLine("Valor total a ser pago: " + Total.ToString("F2"));
           
        }
    }
}
