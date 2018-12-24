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

            Index second = 1;
            Index thirdLast = ^3;

            Console.WriteLine($"Second item in the list: {fruits[second]}");
            Console.WriteLine($"Third last item in the list: {fruits[thirdLast]}");
            Console.WriteLine("Listing all items from the second to the third last item:");

            foreach (var fruit in fruits[second..thirdLast])
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
