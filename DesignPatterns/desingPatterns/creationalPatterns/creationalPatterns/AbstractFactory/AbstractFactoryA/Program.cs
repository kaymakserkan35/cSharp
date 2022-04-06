using AbstractFactoryA.Classses;
using System;

namespace AbstractFactoryA
{
    class Program
    {
        static void Main(string[] args)
        {
            GUIFactory winfactory = new WinFactory();
            winfactory.createButton().Paint();
          

            GUIFactory macfactory = new MacFactory();
            macfactory.createButton().Paint();

        }
    }
}
