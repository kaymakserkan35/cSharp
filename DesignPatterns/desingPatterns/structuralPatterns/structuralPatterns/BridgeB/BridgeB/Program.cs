using System;

namespace BridgeB
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteImplementationA concreteImplementationA = new ConcreteImplementationA();
            Abstraction abstraction = new Abstraction(concreteImplementationA);


            abstraction.Feature1();
            abstraction.Feature2();

            RefinedAbstraction refinedAbstraction = new RefinedAbstraction(concreteImplementationA);

            refinedAbstraction.FeatureN();


        }
    }
}
