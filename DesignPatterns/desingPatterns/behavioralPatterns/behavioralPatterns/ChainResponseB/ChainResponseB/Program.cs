using ChainResponseB.ChainResponseB;
using System;
using System.Collections.Generic;

namespace ChainResponseB
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginHandler loginHandler = new LoginHandler();
            MemberHandler memberHandler = new MemberHandler();
            AdminHandler adminHandler = new AdminHandler();
            loginHandler
                .SetNext(memberHandler)
                .SetNext(adminHandler);

            HandlerMethod(loginHandler);
            HandlerMethod(memberHandler);
            HandlerMethod(adminHandler);





            static void HandlerMethod(AHandler handler )
            {
                foreach (var request in new List<string> { "request-admin", "request-member", "request-login" })
                {

                    var result = handler.Handle(request);

                    if (result != null)
                    {
                        Console.Write($"   {result}");
                    }
                    else
                    {
                        Console.WriteLine($"   {request} was left untouched.");
                    }
                }
            }

           

        }
    }
}
