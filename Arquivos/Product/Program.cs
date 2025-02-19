using Course.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file: ");
            string sourceFile = Console.ReadLine();

            try
            {
                string[] file = File.ReadAllLines(sourceFile);

                string sourceFolder = Path.GetDirectoryName(sourceFile);
                string targetFolder = sourceFolder + @"\out";
                string targetFile = targetFolder + @"\summary.csv";

                Directory.CreateDirectory(targetFolder);

                using (StreamWriter streamWriter = File.AppendText(targetFile))
                {
                    foreach (string line in file)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        streamWriter.WriteLine(product.Name + "," + product.Total().ToString("F2"));
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Error");
                Console.WriteLine(error.Message);
            }
        }
    }
}