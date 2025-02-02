using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string format = "dd/MM/yyyy HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;

            Comment comment1 = new Comment("Have nice trip!");
            Comment comment2 = new Comment("Wow that's awesome!");
            Post post1 = new Post(
                DateTime.ParseExact("21/06/2025 13:05:44", format, provider),
                "Traveling to Brazil",
                "I'm going to live in this beautiful country",
                12
            );

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good night!");
            Comment comment4 = new Comment("May the force be with you!");
            Post post2 = new Post(
                DateTime.ParseExact("28/07/2022 22:30:13", format, provider),
                "Good night guys",
                "See you tomorrow",
                8
            );

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            
            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}