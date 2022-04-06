using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    abstract public class AbstractButton
    {
        public abstract void Render();
        public abstract void OnClick();
    }
}
