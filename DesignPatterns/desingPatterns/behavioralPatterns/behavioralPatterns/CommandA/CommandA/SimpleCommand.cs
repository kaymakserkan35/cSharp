using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandA
{
    class SimpleCommand : ACommand
    {
        private string payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this.payload = payload;
        }

        public override void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this.payload})");
        }
    }
}
