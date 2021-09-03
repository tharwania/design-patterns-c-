using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete.Html;
using AbstractFactoryPattern.Concrete.WinForm;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gUIFactory = CreateFactory("1");

            // here everything for the button checkboxes is encapsulated
            // you can control entire behaviour of program from just one parameter

            var button  = gUIFactory.CreateButton();
            var checkbox = gUIFactory.CreateCheckBox();
        }

        private static IGUIFactory CreateFactory(string output)
        {
            switch (output)
            {
                case "1":
                    return new WinFormGUIFactory();
                case "2":
                    return new HTMLGUIFactory();
                default:
                    return new HTMLGUIFactory();
            }
        }
    }
}
