using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeA.PrototypeSimple
{
    abstract class APrototype : ICloneable
    {
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }

        public PrototypeDetails prototypeDetails { get; set; }

        public abstract object Clone();

    }
}
