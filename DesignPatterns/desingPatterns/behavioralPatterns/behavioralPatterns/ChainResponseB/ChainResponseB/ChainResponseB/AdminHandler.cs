using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseB.ChainResponseB
{
    class AdminHandler : AHandler
    {
        

        public override object Handle(object request)
        {
            if (request.ToString().Contains("admin"))
            {
                return ("Hola admin!...");
            }
            return base.Handle(request);
        }
    }
}
