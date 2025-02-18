using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;

        while (cont)
        {
       
            
            Console.WriteLine("1 - Sum: + ");
            Console.WriteLine("2 - Subtraction: - ");
            Console.WriteLine("3 - Multiplication: * ");
            Console.WriteLine("4 - Division: / ");
            Console.Write("Choose an operation: ");
            char option = Console.ReadLine()[0];

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (option)
            {
                case '1':
                    result = num1 + num2;
                    break;
                case '2':
                    result = num1 - num2;
                    break;
                case '3':
                    result = num1 * num2;
                    break;
                case '4':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.Write("Do you want another operation? (y/n):");
            char respost = Console.ReadLine()[0];

            if (respost == 'n' || respost == 'N')
            {
                cont = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Program Finish.");
    }
}