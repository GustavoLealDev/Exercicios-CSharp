using System;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("1 - Sum: + ");
            Console.WriteLine("2 - Subtraction: - ");
            Console.WriteLine("3 - Multiplication: * ");
            Console.WriteLine("4 - Division: / ");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose an operation: ");
            option = int.Parse(Console.ReadLine());

            if (option == 5)
            {
                Console.WriteLine("Leaving...");
                break;
            }

            else if (option < 1 || option > 5)
            {
                Console.WriteLine("Invalid option!");
                continue;
            }

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    break;
            }
            Console.WriteLine($"Result: {result}");

        } while (true);
    }
}
