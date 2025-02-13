using System;
using System.Data;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string dateInput = Console.ReadLine();
            DateTime birthDate;
            if (!DateTime.TryParseExact(dateInput, new[] { "dd/MM/yyyy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Invalid date format. Please use DD/MM/YYYY");
                return;
            }

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data (PendingPayment | Processing | Shipped | Delivered): ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, client, status);
            
            Console.WriteLine();

            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= N; i++) 
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrdemItem orderItem = new OrdemItem(quantity, price, product);
                Console.WriteLine();
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);

        }
    }
}