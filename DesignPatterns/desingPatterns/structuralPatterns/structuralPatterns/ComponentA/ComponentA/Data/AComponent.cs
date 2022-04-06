using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentA.Data
{
    abstract class AComponent
    {
        public AComponent() { }
        public abstract string Execute();
        public virtual AComponent Add(AComponent component) { return this; }
        public virtual AComponent Remove(AComponent component) { return this; }
        public virtual bool IsComposite()
        { return true; }
    }
}
