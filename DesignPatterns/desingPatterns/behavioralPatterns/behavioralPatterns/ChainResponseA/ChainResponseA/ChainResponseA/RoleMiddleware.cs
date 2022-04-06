using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseA.ChainResponseA
{
    class RoleMiddleware : AMiddleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Contains("admin"))
            {
                Console.WriteLine("hola admin!");
                return true;
            }
          
                Console.WriteLine("hola user!");
                return CheckNext(email, password);
            
           
         
        }
    }
}
