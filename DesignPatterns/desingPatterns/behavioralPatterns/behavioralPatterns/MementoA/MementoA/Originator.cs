using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoA
{
    class Originator
    {
        private string state; // sınıfın bütün propertylerini temsil ediyor!

        public Originator(string state)
        {
            this.state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important. wait...");
            Thread.Sleep(500);
            this.state = Guid.NewGuid().ToString();
            Console.WriteLine($"Originator: and my state has changed to: {state}");
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this.state);
        }

        public void Restore(IMemento memento)
        {
            this.state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {state}");
        }
    }
}
