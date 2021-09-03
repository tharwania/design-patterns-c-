using System;

namespace BridgePattern
{
    class Rectange : IShape
    {
        public IColor Color { get; set; }

        public void Draw()
        {
            Console.ForegroundColor = Color.ConsoleColor;
            Console.WriteLine(@"|__|");
        }
    }
}
