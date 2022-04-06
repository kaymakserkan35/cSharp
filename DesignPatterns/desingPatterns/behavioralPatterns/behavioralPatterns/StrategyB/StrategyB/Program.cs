using System;

namespace StrategyB
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine(/*----------------------------------*/);

            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
