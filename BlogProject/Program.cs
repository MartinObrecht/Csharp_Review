using System;
using BlogProject.Entities;

namespace BlogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's a awesome!");

            Post p1 = new Post(
                DateTime.Parse("28/03/2009"),
                "Travelling to New Zeland",
                "I'm going to New Zeland Museum",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("good night");
            Comment c4 = new Comment("May the force be with you!");

            Post p2 = new Post(
                DateTime.Parse("24/06/2021"),
                "Good night guys",
                "See you tomorrow",
                5);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
