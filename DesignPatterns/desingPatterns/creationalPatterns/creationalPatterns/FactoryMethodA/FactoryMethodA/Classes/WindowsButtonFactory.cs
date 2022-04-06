using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    public class WindowsButtonFactory : AbstractFactory
    {
        public override AbstractButton CreateButton()
        {
            Console.WriteLine("windows button is created!");
            return new WindowsButton();
        }
    }
}
