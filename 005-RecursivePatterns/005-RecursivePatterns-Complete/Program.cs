using System;

namespace _005_RecursivePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var vitorsCat = new Cat
            {
                Name = "Bob",
                Human = new Human
                {
                    Name = "Vitor"
                }
            };

            object animal = vitorsCat;

            if (animal is Cat { Human { Name: "Vitor" }: Human human })
            {
                human.FeedCat();
            }
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public Human Human { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }
        public void FeedCat() => Console.WriteLine("Feeding the cat.");
    }
}
