using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandA
{
    class Invoker
    {
        private ACommand onStart;
        private ACommand onFinish;

        public void SetOnStart(ACommand command)
        {
            this.onStart = command;
        }

        public void SetOnFinish(ACommand command)
        {
            this.onFinish = command;
        }

       
        public void DoSomethingImportant()//executeCommand
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this.onStart is ACommand)
            {
                this.onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this.onFinish is ACommand)
            {
                this.onFinish.Execute();
            }
        }
    }
}
