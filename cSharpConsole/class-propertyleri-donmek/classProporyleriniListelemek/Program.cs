
using System;
using System.Collections.Generic;
using System.Reflection;

namespace classProporyleriniListelemek
{

    public class MyClass
    {

        public MyClass()
        {
            MyProperty3 = new List<string>() { "1", "2" };
        }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public List<string> MyProperty3 { get; set; }





    }


    class Program
    {

        static void Main(string[] args)
        {

            MyClass myClass = new MyClass() { MyProperty1 = 1 };


            PropertyInfo[] myPropertyInfo;
            myPropertyInfo = Type.GetType(myClass.ToString()).GetProperties();
            Console.WriteLine("Properties of System.Type are:");
    
     

            
        }
    }
}
