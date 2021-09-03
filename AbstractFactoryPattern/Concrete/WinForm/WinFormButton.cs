using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete.WinForm
{
    internal class WinFormButton : IButton
    {
        public string Text { get; set; }
    }
}