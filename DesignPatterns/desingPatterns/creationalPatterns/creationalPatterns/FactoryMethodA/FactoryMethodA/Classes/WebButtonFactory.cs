using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    public class WebButtonFactory : AbstractFactory
    {
        public override AbstractButton CreateButton()
        {
            Console.WriteLine("Web button is created");
            return new WebButton();
        }
    }
}
