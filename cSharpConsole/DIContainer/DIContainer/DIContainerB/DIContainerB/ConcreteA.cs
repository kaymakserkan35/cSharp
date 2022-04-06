using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainerB
{
    class ConcreteA : IInterface
    {
        public void MethodToOverride()
        {
            Console.WriteLine("Method from ConcreteA");
        }
    }
}
