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

            fileLogger.Log(new Exception("Oops, something went wrong..."));
            dbLogger.Log(new Exception("Oops, something went wrong..."));
        }
    }

    public interface ILogger
    {
        void Log(string message);

        // At the time of writing of these sample projects this feature
        // is still in prototype, so this project will still not compile on
        // dotnet SDK 3.0.100-preview-009812
        void Log(Exception ex) => Console.WriteLine(ex.Message);
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
