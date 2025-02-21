using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Prodcut #{i} data: ");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (cui == 'c' || cui == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (cui == 'i' || cui == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.Write("Manufacture (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }

        }
    }
}