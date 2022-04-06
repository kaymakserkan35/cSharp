using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryA.Classses
{
    public class WinFactory : GUIFactory
    {
        public AbstractButton createButton()
        {
            Console.WriteLine("WİnButton created");
            return new WinButton();
        }
    }
}
