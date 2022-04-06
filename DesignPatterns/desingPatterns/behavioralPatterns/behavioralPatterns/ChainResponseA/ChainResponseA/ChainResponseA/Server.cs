using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseA.ChainResponseA
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>()
        { {"email","password"}};
        private AMiddleware middleware;

        public void SetMiddleware(AMiddleware middleware)
        {
            this.middleware = middleware;
        }

        public bool Login ( string email, string password)
        {
            if (middleware.Check(email,password))
            {
                Console.WriteLine("Authorization have been successful!");
                return true;
            }
            return false;
        }

        public void Register(string email , string password)
        {
            users.Add(email, password);
        }

        public bool IsUserExist(string email, string password)
        {
            var tf1 = users.ContainsKey(email);
            var tf2 = users.ContainsValue(password);
            if (tf1 && tf2)
            {
                return true;
            }
            return false;
        }

    }
}
