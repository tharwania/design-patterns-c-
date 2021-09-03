using System;

namespace FactoryPattern
{
    internal class FileLogger : ILog
    {
        public void Log(string text)
        {
            Console.WriteLine($"FileLogger: {text}");
        }
    }
}