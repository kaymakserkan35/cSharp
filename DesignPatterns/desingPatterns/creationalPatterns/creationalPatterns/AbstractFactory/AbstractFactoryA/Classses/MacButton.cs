using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryA.Classses
{
    public class MacButton : AbstractButton
    {
        public override AbstractButton Paint()
        {
            Console.WriteLine("macbutton dizaynı...");
            return this;
        }
    }
}
