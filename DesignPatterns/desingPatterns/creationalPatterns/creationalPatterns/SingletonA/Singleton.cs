using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonA
{
    public class Singleton
    {
        private static int count;
        private readonly string name;
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            count++;
            name = "Singleton" + count;
            Console.Write(name +":");
            Console.WriteLine(this.GetHashCode());
        }
        public static Singleton GetInstance
        {
            get { return singleton; }

        }

    }
}
