using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseB.ChainResponseB
{
    class LoginHandler : AHandler
    {
     

        public override object Handle(object request)
        {
            var requeststring = request as string;
            if(!requeststring.Contains("login"))
            { return " login olmalısınız.. "; }

            return base.Handle(request);
        }

    }
}
