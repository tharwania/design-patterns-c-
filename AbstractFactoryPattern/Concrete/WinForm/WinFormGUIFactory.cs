using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete.WinForm
{
    public class WinFormGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinFormButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinFormCheckBox();
        }
    }
}
