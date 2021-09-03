using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete.Html
{
    internal class HTMLCheckBox : ICheckBox
    {
        public string Text { get; set; }
        public bool Value { get; set; }
    }
}