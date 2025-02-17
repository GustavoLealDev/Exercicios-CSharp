using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            int option;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Add Motocycle");
                Console.WriteLine("3. Add Trucker");
                Console.WriteLine("4. Remove Vehicle");
                Console.WriteLine("5. List Vehicles");
                Console.WriteLine("0. Leave");
                Console.Write("Choose a option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Model: ");
                        string model = Console.ReadLine();
                        Console.Write("Year manufacture: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        double fip = double.Parse(Console.ReadLine());
                        stock.AddVehicle(new Cars(brand, model, year, fip));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Brand: ");
                        brand = Console.ReadLine();
                        Console.Write("Model: ");
                        model = Console.ReadLine();
                        Console.Write("Year manufacture: ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        fip = double.Parse(Console.ReadLine());
                        stock.AddVehicle(new Motocycle(brand, model, year, fip));
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Brand: ");
                        brand = Console.ReadLine();
                        Console.Write("Model: ");
                        model = Console.ReadLine();
                        Console.Write("Year manufacture: ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        fip = double.Parse(Console.ReadLine());
                        stock.AddVehicle(new Cars(brand, model, year, fip));
                        Console.WriteLine();
                        break;
                    case 4:
                        stock.ListVehicle();
                        Console.Write("Model of vehicle to be removed: ");
                        model = Console.ReadLine();
                        stock.RemoveVehicle(model);
                        break;
                    case 5:
                        stock.ListVehicle();
                        break;
                    case 0:
                        Console.WriteLine("Leaving...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (option != 0);
        }
    }
}