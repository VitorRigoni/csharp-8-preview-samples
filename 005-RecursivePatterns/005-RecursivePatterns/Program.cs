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

            if(animal.GetType() == typeof(Cat))
            {
                var realCat = (Cat)animal;
                if (realCat.Human != null && realCat.Human.Name == "Vitor") {
                    realCat.Human.FeedCat();
                }
            }

            if (animal is Cat cat && cat.Human?.Name == "Vitor")
            {
                cat.Human.FeedCat();
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
