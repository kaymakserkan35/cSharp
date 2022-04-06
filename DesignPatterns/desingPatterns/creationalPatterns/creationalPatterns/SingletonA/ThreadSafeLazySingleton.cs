using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonA
{


    namespace SingletonA
    {
        public class ThreadSafeLazySingleton
        {
            private static object OneChannelControlObject = new Object();
            private static int count;
            private readonly string name;
            public static ThreadSafeLazySingleton threadSafeLazySingleton;

            private ThreadSafeLazySingleton()
            {
                count++;
                name = "threadSafeLazySingleton" + count;
                Console.Write(name + ":");
                Console.WriteLine(this.GetHashCode());
            }
            public static ThreadSafeLazySingleton GetInstance
            {
                get
                {
                    if (threadSafeLazySingleton == null)
                    {
                        lock (OneChannelControlObject) //locklama
                        {
                            if (threadSafeLazySingleton == null)
                            {
                                threadSafeLazySingleton = new ThreadSafeLazySingleton();
                            }
                        }
                    }
                    return threadSafeLazySingleton;
                }
            }
        }
    }

}
