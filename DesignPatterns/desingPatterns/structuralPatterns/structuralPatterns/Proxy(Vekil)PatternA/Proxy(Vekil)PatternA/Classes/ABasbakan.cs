using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Vekil_Pattern1
{
    public abstract class ABasbakan
    {
        abstract public ABasbakan DertDinle(string dert);
        abstract public ABasbakan IsBul(string yakınım);

    }
}
