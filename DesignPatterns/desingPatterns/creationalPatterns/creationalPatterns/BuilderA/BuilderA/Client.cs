using BuilderA.BuilderClasses;
using System;

namespace BuilderA
{
    class Client
    {
        static void Main(string[] args)
        {
            IComputerBuilder computerBuilder = new ComputerBuilder();
            var computer = computerBuilder.BuildBIOS().BuildGraphicCard().GetComputer();
            Console.WriteLine(computer);
        }
    }
}
