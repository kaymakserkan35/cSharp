using SingletonA.SingletonA;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SingletonA
{

    class Program
    {


        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                Singleton singleton = Singleton.GetInstance;
            }
            //for (int i = 0; i < 1; i++)
            //{
            //    LazySingleton lazysingleton = LazySingleton.GetInstance;
            //}
            for (int i = 0; i < 10; i++)
            {
                Thread thr = new Thread(() =>
                {
                    LazySingleton thrLazysingleton = LazySingleton.GetInstance;
                });
                thr.Start();
            }
            for (int i = 0; i < 1000; i++)
            {
                Thread thr = new Thread(() =>
                {
                    ThreadedLazySingleton thrLazysingleton = ThreadedLazySingleton.GetInstance;
                });
                thr.Start();
            }
            for (int i = 0; i < 1000; i++)
            {
                Thread thr = new Thread(() =>
                {
                    ThreadSafeLazySingleton thrLazysingleton = ThreadSafeLazySingleton.GetInstance;
                });
                thr.Start();
            }


        }

    }
}
