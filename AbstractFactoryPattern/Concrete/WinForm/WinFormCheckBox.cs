using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete.WinForm
{
    public class WinFormCheckBox : ICheckBox
    {
        public string Text { get; set; }
        public bool Value { get; set; }
    }
}