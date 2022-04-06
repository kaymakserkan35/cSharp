using PrototypeA.PrototypeSimple;
using System;

namespace PrototypeA
{
    class Client
    {
        static void Main(string[] args)
        {
            var prototype = new ConcretePrototype()
            {
                MyProperty1 = "MyProperty1...",
                MyProperty2 = "MyProperty1...",
                prototypeDetails = new PrototypeDetails()
                {
                    detailA = 1,
                    detailB = "iki",
                    detailC = true
                }
            };

            var newObject = prototype.Clone();
            ConcretePrototype ClonePrototype = newObject as ConcretePrototype;
            ClonePrototype.prototypeDetails.detailA = 11;

        }
    }
}
