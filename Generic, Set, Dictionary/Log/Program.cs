﻿using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Log> set = new HashSet<Log>();

            Console.Write("Enter with path: ");
            string path = Console.ReadLine();

            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] line = streamReader.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new Log { Name = name, Moment = instant });
                    }
                    Console.WriteLine("USERS: " + set.Count);
                }
            }
        }
    }
}