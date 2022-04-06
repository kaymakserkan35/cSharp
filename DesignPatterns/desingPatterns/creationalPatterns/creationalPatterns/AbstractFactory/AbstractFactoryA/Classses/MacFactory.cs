using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryA.Classses
{
    public class MacFactory : GUIFactory
    {
        public AbstractButton createButton()
        {
            Console.WriteLine("MacButton created");
            return new MacButton();
        }
    }
}
