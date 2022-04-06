using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonA
{
    class ThreadedLazySingleton
    {
        private static int count;
        private readonly string name;
        private static Lazy<ThreadedLazySingleton> threadedLazySingleton = null;

        private ThreadedLazySingleton()
        {
            count++;
            name = "threadedLazySingleton" + count;
            Console.Write(name + ":");
            Console.WriteLine(this.GetHashCode());
        }
        public static ThreadedLazySingleton GetInstance
        {
            get
            {
                if (threadedLazySingleton == null)
                {
                    threadedLazySingleton = new Lazy<ThreadedLazySingleton>(() => new ThreadedLazySingleton());
                   
                }
                return threadedLazySingleton.Value;
            }

        }
    }
}
