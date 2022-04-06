using System;
using System.Threading;

namespace ThreadWorkClient
{

    class Program
    {

        static void Main(string[] args)
        {

            MultiThreadingWithLockControl multiThreadingWithLockControl = new MultiThreadingWithLockControl();

            multiThreadingWithLockControl.th1.Start();
            multiThreadingWithLockControl.th2.Start();


            /*----------------------------------------------------------------------------------*/

            MultiThreading multiThreading = new MultiThreading();

            multiThreading.th1.Start();
            multiThreading.th2.Start();


        }
    }
}
