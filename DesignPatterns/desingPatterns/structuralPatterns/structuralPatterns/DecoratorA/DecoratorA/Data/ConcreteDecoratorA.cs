using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorA.Data
{
    class ConcreteDecoratorA : ADecorator
    {
        public ConcreteDecoratorA(AComponent component) : base(component)
        {
        }

        public override string Execute()
        {
            return $"ConcreteDecoratorA({base.Execute()})";
        }
    }
}
