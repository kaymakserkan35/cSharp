using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeB.BasicImp
{
    abstract class AbstractPrototype : ICloneable
    {
        public abstract object Clone();
    }
}
