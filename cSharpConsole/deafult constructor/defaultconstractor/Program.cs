using System;

namespace defaultconstractor
{
    class myclass
    {
        public string MyProperty { get; set; }

        public myclass(string myProperty)
        {
            MyProperty = myProperty;
            Console.WriteLine(MyProperty);
        }

        public myclass()
        {
            Console.WriteLine("defaultconstructor");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            myclass myobj = new myclass("serkan");
        }
    }
}
