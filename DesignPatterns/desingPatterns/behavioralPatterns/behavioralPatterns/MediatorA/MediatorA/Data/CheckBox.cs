using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorA.Data
{
    class CheckBox : AComponent
    {
        public CheckBox(IMediator mediator) : base(mediator)
        {
        }

        public void check() { mediator.Notify(this, "checked"); }

        public void Execute() { Console.WriteLine("checkbox  methodu execute edildi"); }

        public override string toString()
        {
            return this.GetType().Name;
        }
    }
}
