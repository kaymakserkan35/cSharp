using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseB.ChainResponseB
{
    class MemberHandler : AHandler

    {
        

        public override object Handle(object request)
        {
            if (request.ToString().Contains("member"))
            {
               return ("hola member!");
            }
            return base.Handle(request);
        }
    }
}
