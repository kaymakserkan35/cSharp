using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandA
{
    class ComplexCommand : ACommand
    {
        private Receiver receiver;
        string[] values;

        public ComplexCommand(Receiver receiver, params string[] values)
        {
            this.receiver = receiver;
            this.values = values;
        }

        public override void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this.receiver.DoSomething(values[0]);
            this.receiver.DoSomethingElse(values);
        }
    }
}
