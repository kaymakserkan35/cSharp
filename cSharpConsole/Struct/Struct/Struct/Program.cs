using System;

namespace Struct
{
    interface IInterface
    {

    }

    struct MyColor : IInterface
    {
        public static MyColor white;
        public static MyColor black;
        public MyColor MyMethod(MyColor myColor)
        {
            return myColor;
        }
    }
    class MyClass
    {
        int myNum = 2;
        MyColor myColor = MyColor.black;
        MyColor myColorObj = new MyColor();
        void method()
        {
            myColorObj.MyMethod(myColor).ToString();
        }

    }

    class Client
    {
        public MyColor[] colors = new MyColor[] { MyColor.white, MyColor.black };
        MyColor[,] myColors = new MyColor[8, 8];
        public MyClass[,,] myClasses2 = new MyClass[8, 8, 8];
        MyColor color = new MyColor();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //client.myClasses1[0, 0] = new MyClass();
            client.colors[0] = MyColor.black;
        }
    }

}
