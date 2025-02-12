using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Course.Entities;
using Course.Entities.Exeptions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int accountId = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("WithDraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(accountId,holder,balance,withDrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                account.WithDraw(amount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2"));
            }
            catch(AccountExeptions e)
            {
                Console.WriteLine("WithDraw error: " + e.Message);
            }
        }
    }
}