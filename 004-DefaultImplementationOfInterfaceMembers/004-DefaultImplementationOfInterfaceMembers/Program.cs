using System;

namespace _004_DefaultImplementationOfInterfaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            ILogger dbLogger = new DatabaseLogger();

            fileLogger.Log("Writing to file.");
            dbLogger.Log("Writing to the database.");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        /// <summary>
        /// Write logs to a text file.
        /// </summary>
        public void Log(string message)
        {
            // For the sake of simplicity for this sample,
            // we'll simply write to the console.
            Console.WriteLine(message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        /// <summary>
        /// Write logs to the database.
        /// </summary>
        public void Log(string message)
        {
            // For the sake of simplicity for this sample,
            // we'll simply write to the console.
            Console.WriteLine(message);
        }
    }
}
