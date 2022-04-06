using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorA.Data
{
    class Button : AComponent
    {
        public Button(IMediator mediator) : base(mediator)
        {
        }


        public void Click()
        {
            mediator.Notify(this, "clicked");
        }

        public void Execute() { Console.WriteLine("buton methodu execute edildi"); }

        public override string toString()
        {
            return this.GetType().Name;
        }
    }
}
