using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete.Html
{
    public class HTMLGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new HTMLButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new HTMLCheckBox();
        }
    }
}
