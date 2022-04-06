using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonA
{
    public class LazySingleton 
    {
        private static int count;
        private readonly string name;
        private static LazySingleton lazysingleton = new LazySingleton();
        private LazySingleton()
        {
            count++;
            name = "LazySingleton" + count;
            Console.Write(name + ":");
            Console.WriteLine(this.GetHashCode());
        }
        public static LazySingleton GetInstance
        {
            get
            {
                if (lazysingleton == null)
                {
                    return lazysingleton = new LazySingleton();
                }
                return lazysingleton;
            }

        }

    }
}
