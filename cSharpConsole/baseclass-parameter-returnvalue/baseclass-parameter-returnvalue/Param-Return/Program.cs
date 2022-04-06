using System;

abstract class Abstract
{

}

class ConcreteA : Abstract
{

}

class ConcreteB : Abstract
{

}

namespace Param_Return
{
    class Program
    {
        static void MyMethod1(Abstract @abstract)
        { }
        static Abstract MyMethod2(Abstract @abstract)
        { return @abstract; }

        static void Main(string[] args)
        {
            MyMethod1(new ConcreteA());
            MyMethod2(new ConcreteB());
        }
    }
}
