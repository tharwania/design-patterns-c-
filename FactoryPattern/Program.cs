using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your Logger");
            Console.WriteLine("1. FileLogger");
            Console.WriteLine("2. ConsoleLogger");
            var output = Console.ReadLine();

            var logger = FactoryPattern.LogFactory.CreateLog(output);

            logger.Log("hey we don't even know on compile time which class is logging");
            logger.Log("That gets decided on runtime.");

            Console.ReadKey();
        }
    }
}
