using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeA.PrototypeSimple
{
    class ConcretePrototype : APrototype
    {
        public override object Clone()
        {
            return new ConcretePrototype
            {
                MyProperty1 = this.MyProperty1,
                MyProperty2 = this.MyProperty2,
                prototypeDetails = new PrototypeDetails()
                {
                    // Details = this.prototypeDetails.Details
                    detailA = this.prototypeDetails.detailA,
                    detailB = this.prototypeDetails.detailB,
                    detailC = this.prototypeDetails.detailC
                }
            };
        }
    }
}
