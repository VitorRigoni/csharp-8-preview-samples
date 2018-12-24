using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using System.IO;

namespace _002_AsyncStreams
{
    class Program
    {
        static IEnumerable<string> ReadLoremIpsumAsync()
        {
            var file = new StreamReader("lorem.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                yield return line;
            }
        }

        static void Main(string[] args)
        {
            foreach (var line in ReadLoremIpsumAsync())
            {
                Console.WriteLine(line);
            }
        }
    }
}
