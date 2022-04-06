using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Vekil_Pattern1
{
    class Basbakan : ABasbakan
    {
        public override ABasbakan DertDinle(string dert)
        {
            Console.WriteLine($"basbakan {dert} dinliyuor...");
            return this;
        }

        public override ABasbakan IsBul(string yakınım)
        {
            Console.WriteLine($"basbakan {yakınım}'a iş buluyor...");
            return this;
        }
    }
}
