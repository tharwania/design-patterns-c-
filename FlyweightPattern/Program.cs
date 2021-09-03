using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are all the chars we'll produce
            List<FormatedCharacter> charArray = new();
            CharFlyweightFactory charFlyweightFactory = new();
            for (int i = 0; i < 10000000; i++)
            {
                charArray.Add(new FormatedCharacter()
                {
                    Bold = i % 10 == 0,
                    Italic = i % 5 == 0,
                    Character = charFlyweightFactory.GetCharacter((char)(i % 128))
                });
            }
            long memory = GC.GetTotalMemory(true);
            Console.WriteLine(memory);
            Console.ReadKey();

            /*
             Chars without flyweight = 694276920
             Chars with flyweight = 454286232
            */
        }
    }
}
