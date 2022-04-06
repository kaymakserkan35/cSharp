using System;

namespace CommandA
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));


            Console.WriteLine("*------------------------------------------*");


            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report","Multible complex jobs..."));

            invoker.DoSomethingImportant();
        }
    }
}
