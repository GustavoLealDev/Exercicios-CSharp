using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (R/C) ? ");
                char rc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (rc == 'r' || rc == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width,height,color));
                    Console.WriteLine();
                } 
                else 
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                    Console.WriteLine();
                }
            }


            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

        }
    }
}