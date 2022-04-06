using System;

namespace MementoA
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator(Guid.NewGuid().ToString());
            CareTaker careTaker = new CareTaker(originator);
            careTaker.Backup();
            originator.DoSomething();
            originator.DoSomething();
            careTaker.Backup();
            careTaker.ShowHistory();
            careTaker.Undo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
