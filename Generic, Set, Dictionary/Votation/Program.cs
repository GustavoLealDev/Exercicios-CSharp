using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            using (StreamReader streamReader = File.OpenText(path))
            {

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                try
                {
                    while (!streamReader.EndOfStream)
                    {

                        string[] Record = streamReader.ReadLine().Split(',');
                        string candidate = Record[0];
                        int votes = int.Parse(Record[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("ERROR!! Try again.");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
