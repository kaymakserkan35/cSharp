using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeB
{
   public interface IImplementation
    {
        public void method1() { Console.WriteLine( "method1 from implementation"); }
        public void method2() { Console.WriteLine("method2 from implementation"); }
        public void method3() { Console.WriteLine("method3 from implementation"); }
        public void methodN() { Console.WriteLine("methodN from implementation"); }
    }
}
