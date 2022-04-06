using DecoratorA.Data;
using System;

namespace DecoratorA
{
    class Program
    {
        static void Main(string[] args)
        {
            var Simplecomponent = new ConcreteComponent();
            Console.WriteLine("RESULT: " + Simplecomponent.Execute());


            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(Simplecomponent);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            Console.WriteLine("RESULT: " + decorator2.Execute());
        }
    }
}
