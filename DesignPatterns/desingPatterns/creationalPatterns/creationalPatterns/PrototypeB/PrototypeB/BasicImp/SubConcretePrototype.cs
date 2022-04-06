using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeB.BasicImp
{
    class SubConcretePrototype : ConcretePrototype
    {
        public string field2 { get; set; }
        public SubConcretePrototype() { }
        public SubConcretePrototype(string _field1):base(_field1){}

        public override AbstractPrototype Clone()
        {
            return new SubConcretePrototype(this.field1)
            {  field2 = this.field2  };
        }
    }
}
