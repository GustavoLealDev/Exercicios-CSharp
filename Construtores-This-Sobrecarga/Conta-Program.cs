using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            
            Console.Write("Entre com o número da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre com o NOME do titular da conta: ");
            string Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)? ");
            char sn = char.Parse(Console.ReadLine());
                if (sn == 'S' || sn == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                double depositoI = double.Parse(Console.ReadLine());
                conta = new Conta (id, Titular, depositoI);
                Console.WriteLine();
            }
            else
            {
                conta = new Conta(id, Titular);
            }

           
            Console.WriteLine("Dados da conta: ");
            Console.Write(conta);

            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double valor = int.Parse(Console.ReadLine());
            conta.AddSaldo(valor);

            Console.WriteLine();
            
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.Write(conta);

            Console.WriteLine();
            
            Console.Write("Entre com um valor para Saque: ");
            valor = int.Parse(Console.ReadLine());
            conta.RemoveSaldo(valor);

            Console.WriteLine();

            Console.WriteLine("Dados da conta Atualizados: ");
            Console.Write(conta);


        }
    }
}