using System;
using FactoryMethodA.Classes;

namespace FactoryMethodA
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory Wind_buttonFactory = new WindowsButtonFactory();
            var Wind_button = Wind_buttonFactory.CreateButton();
            Wind_button.OnClick();

            AbstractFactory Html_buttonFactory = new WebButtonFactory();
            var Html_button = Html_buttonFactory.CreateButton();
            Html_button.OnClick();
        }
    }
}
