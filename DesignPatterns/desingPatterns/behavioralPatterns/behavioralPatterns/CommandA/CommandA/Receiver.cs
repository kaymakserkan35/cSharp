using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandA
{
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(params string[] values)
        {
            foreach (var str in values)
            {
                Console.WriteLine($"Receiver: Also working on ({str}.)");
            }
           
        }
    }
}
