using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorA.Data
{
    class ConcreteComponent : AComponent
    {
        public override string Execute()
        {
            return "ConcreteComponent";
        }
    }
}
