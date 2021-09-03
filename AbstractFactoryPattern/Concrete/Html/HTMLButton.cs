using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete.Html
{
    internal class HTMLButton : IButton
    {
        public string Text { get; set; }
    }
}