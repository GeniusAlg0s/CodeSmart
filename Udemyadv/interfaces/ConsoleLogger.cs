using System;

namespace interface_etensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            //throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            //throw new NotImplementedException();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
