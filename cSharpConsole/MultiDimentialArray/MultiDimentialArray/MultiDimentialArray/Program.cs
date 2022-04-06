using System;
using System.Collections.Generic;

namespace MultiDimentialArray
{
    struct MyColor
    {
        public static MyColor white;
        public static MyColor black;
        public static MyColor red;
    }
    class MyClass
    {

    }

    class Client
    {
        public MyColor[] colors = new MyColor[] { MyColor.white, MyColor.black };
        public MyClass[,] myClasses1 = new MyClass[8, 8];
        public MyClass[,,] myClasses2 = new MyClass[8, 8, 8];
        // public List<MyClass, MyClass> ts = new System.Collections.Generic.List<MyClass, MyClass>();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.myClasses1[0, 0] = new MyClass();
            client.colors[0] = MyColor.black;
        }
    }
}
