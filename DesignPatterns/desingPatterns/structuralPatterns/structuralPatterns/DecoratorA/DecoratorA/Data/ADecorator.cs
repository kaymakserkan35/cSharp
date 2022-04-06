using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorA.Data
{
    abstract class ADecorator : AComponent
    {
        protected AComponent component;

        protected ADecorator(AComponent component)
        {
            this.component = component;
        }

        public ADecorator SetComponent(AComponent component)
        {
            this.component = component;
            return this;
        }

        public override string Execute()
        {
            if (this.component != null)
            {
                return this.component.Execute();
            }
            return string.Empty;
        }
    }
}
