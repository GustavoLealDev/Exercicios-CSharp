using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CONTRACT DATA: ");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int mounths = int.Parse(Console.ReadLine());

            Contract contract = new Contract(id, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, mounths);

            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment installment in contract.Installments) 
            {
                Console.WriteLine(installment);
            }
        }
    }
}