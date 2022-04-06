using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorA.Classes
{
    class Adapter : ATarget
    {
        private readonly Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public override string GetRequest()
        {
            return $"This is '{this.adaptee.GetSpecificRequest()}'";
        }
    }
}
