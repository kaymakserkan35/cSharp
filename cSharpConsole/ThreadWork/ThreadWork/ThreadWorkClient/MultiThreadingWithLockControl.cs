using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadWorkClient
{
    class MultiThreadingWithLockControl
    {


        static Object control = new object();

        public Thread th1 = new Thread(() =>
         {
             lock (control)
             {
                 for (int i = 0; i < 1000; i++)
                 {
                     Console.WriteLine("working ------------------------ A");
                 }
             }
         });

        public Thread th2 = new Thread(() =>
         {
             lock (control)
             {
                 for (int i = 0; i < 1000; i++)
                 {
                     Console.WriteLine("working B");
                 }
             }
         });
    }
}
