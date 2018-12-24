using System;

namespace _003_RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =
            {
                "Apple",
                "Banana",
                "Pear",
                "Coconut",
                "Açaí",
                "Tangerine",
                "Orange"
            };

            Console.WriteLine($"Second item in the list: {fruits[1]}");
            Console.WriteLine($"Third last item in the list: {fruits[fruits.Length - 3]}");
            Console.WriteLine("Listing all items from the second to the third last item:");

            for (int i = 1; i < fruits.Length - 3; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
