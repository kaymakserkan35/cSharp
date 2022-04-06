using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChainResponseA.ChainResponseA
{
    class ThrottlinkMiddleware : AMiddleware
    {
        private int requestPerMinute;
        private int request;
        private long currentTime;

        public ThrottlinkMiddleware(int requestPerMinute)
        {
            this.requestPerMinute = requestPerMinute;
            this.currentTime = DateTime.Now.Millisecond;
        }
        public override bool Check(string email, string password)
        {
            if (DateTime.Now.Millisecond>currentTime+60000)
            {
                request = 0;
                currentTime = DateTime.Now.Millisecond;
            }
            request++;



            if (request>requestPerMinute)
            {
                Console.WriteLine("Request limit exceeded!");
                Thread.CurrentThread.Abort();
            }

            return CheckNext(email, password);
        }


        


    }
}
