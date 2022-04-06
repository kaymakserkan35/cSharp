using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoA
{
    class CareTaker
    {
        List<IMemento> mementos = new List<IMemento>();
        Originator originator = null;

        public CareTaker(Originator originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this.mementos.Add(this.originator.Save());
        }

        public void Undo()
        {
            if (this.mementos.Count==0)
            {
                return;
            }
            var memento = this.mementos.Last();
            this.mementos.Remove(memento);
            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());
            this.originator.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this.mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
