using System;

namespace _001_NullableReferenceTypes
{
    class Program
    {
        /*
            This example throws a null reference exception.
            The important part of this example is to demonstrate
            how C#8 shows warnings indicating possible null reference exceptions
            unless you explicitly tell the compiler that you are expecting null.

            Note that this won't fail the build.
        */
        static void Main(string[] args)
        {
            string myString = null; 

            Console.WriteLine($"Length of myString is: {myString.Length}");
        }
    }
}
