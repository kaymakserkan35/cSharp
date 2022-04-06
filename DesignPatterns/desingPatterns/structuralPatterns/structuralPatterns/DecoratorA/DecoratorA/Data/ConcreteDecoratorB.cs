using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorA.Data
{
    class ConcreteDecoratorB : ADecorator
    {
        public ConcreteDecoratorB(AComponent component) : base(component)
        {
        }

        public override string Execute()
        {
            return $"ConcreteDecoratorB({base.Execute()})";
        }
    }
}
