using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer
{
    public interface IInterface
    {
        public void methodFromInterface() { Console.WriteLine("method from interface..."); }
        void MethodToOverride();
    }
}
