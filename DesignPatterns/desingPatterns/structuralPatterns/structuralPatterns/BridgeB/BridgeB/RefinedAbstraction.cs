using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeB
{
   public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public void FeatureN()
        {
            implementation.methodN();
        }
    }
}
