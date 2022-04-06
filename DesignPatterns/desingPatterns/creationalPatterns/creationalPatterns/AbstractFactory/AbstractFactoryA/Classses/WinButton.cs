using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryA.Classses
{
    public class WinButton : AbstractButton
    {
        public override AbstractButton Paint()
        {
            Console.WriteLine("win button dizaynı...");
            return this;
        }
    }
}