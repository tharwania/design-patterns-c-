using System;

namespace FactoryPattern
{
    internal class ConsoleLogger : ILog
    {
        public void Log(string text)
        {
            Console.WriteLine($"ConsoleLogger: {text}");
        }
    }
}