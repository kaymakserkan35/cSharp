using System;

namespace enumApp
{

    enum MyEnum
    {
        txt0,txt1,txt2,txt3,txt4
    }



    class Program
    {
        static void Main(string[] args)
        {

            var tip = typeof(MyEnum);
            var a = MyEnum.txt1;
            var b = (int)MyEnum.txt1;
            var c = (object)MyEnum.txt1;
           



            //var c = Enum.GetName(typeof(MyEnum), 2);
            //var d = Enum.GetNames(typeof(MyEnum));
            //var e1 = Enum.GetValues(typeof(MyEnum));
          
            //var e2 = Enum.GetValues<MyEnum>();

            //MyEnum enumobj = MyEnum.txt3;
            //var f = Enum.Format(typeof(MyEnum), enumobj, "d");
            //var f1 = MyEnum.txt3;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            
            //Console.WriteLine(c);

            //foreach (var item in d)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in e1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(f);

        }







    }
}
