using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseA.ChainResponseA
{
   abstract class AMiddleware
    {
        private AMiddleware next;


        public AMiddleware LinkWith(AMiddleware next)
        {
            this.next = next;
            return next;
        }

        public abstract bool Check(string email, string password);
        protected bool CheckNext ( string email , string password)
        {
            if (next != null)
            {
                return next.Check(email, password);
            }
            return true;
        }
    }
}
