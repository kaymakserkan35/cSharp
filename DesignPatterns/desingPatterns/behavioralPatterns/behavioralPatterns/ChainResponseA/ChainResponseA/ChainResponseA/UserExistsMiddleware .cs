using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseA.ChainResponseA
{
    class UserExistsMiddleware : AMiddleware
    {
        private Server server;
        public UserExistsMiddleware(Server server)
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            var tf=  server.IsUserExist(email, password);
            if (tf)
            {
                CheckNext(email, password);
            }
            return false;
        }
    }
}
