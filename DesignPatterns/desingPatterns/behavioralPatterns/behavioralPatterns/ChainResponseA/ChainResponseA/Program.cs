using ChainResponseA.ChainResponseA;
using System;

namespace ChainResponseA
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            server.Register("serkan-admin35@hotmail", "123");
            server.Register("serkan-user35@hotmail", "123");
            server.Register("admin", "");
            server.Register("member", "");
            AMiddleware middleware = new ThrottlinkMiddleware(2);
            middleware
                .LinkWith(new UserExistsMiddleware(server))
                .LinkWith(new RoleMiddleware());
            server.SetMiddleware(middleware);


            bool success;
            do
            {
                Console.WriteLine ("Enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Input password: ");
                string password = Console.ReadLine();
                success = server.Login(email, password);
            } while (!success);
        }
    }
}
