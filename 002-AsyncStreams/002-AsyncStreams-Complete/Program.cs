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
        static async IAsyncEnumerable<string> ReadLoremIpsumAsync()
        {
            var file = new StreamReader("lorem.txt");
            string line;
            while ((line = await file.ReadLineAsync()) != null)
            {
                yield return line;
                await Task.Delay(200);
            }
        }

        static async Task Main(string[] args)
        {
            await foreach (var line in ReadLoremIpsumAsync())
            {
                Console.WriteLine(line);
            }
        }
    }
}
