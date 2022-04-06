using MediatorA.Data;
using System;

namespace MediatorA
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();
            Button btn = new Button(mediator);
            btn.Click();

            CheckBox checkbox = new CheckBox(mediator);
            checkbox.check();
        }
    }
}
