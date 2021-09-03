using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface ICommand
    {
        void Execute();
    }

    interface IInvoker
    {
        void Invoke();
    }


}
