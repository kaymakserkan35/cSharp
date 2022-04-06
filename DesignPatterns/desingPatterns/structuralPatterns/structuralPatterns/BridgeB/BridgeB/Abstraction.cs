using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeB
{
    public class Abstraction
    {
        public IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public void Feature1()
        {
            implementation.method1();
        }

        public void Feature2()
        {
            implementation.method2();
            implementation.method3();
        }
    }
}
