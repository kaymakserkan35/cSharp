using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeB.BasicImp
{
    class ConcretePrototype : AbstractPrototype
    {
        public string field1 { get; set; }
        public ConcretePrototype() { }
        public ConcretePrototype(string _field1)
        { this.field1 = _field1; }
        public override AbstractPrototype Clone()
        {
            return new ConcretePrototype(this.field1)  { };
        }
    }
}
