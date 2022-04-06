using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Vekil_Pattern1
{
    class VekilBasbakan : ABasbakan
    {
        private ABasbakan aBasbakan;
        public VekilBasbakan(ABasbakan aBasbakan)
        {
            this.aBasbakan = aBasbakan;
        }



        public bool DertAyır(string dert)
        {
            Console.WriteLine("vekil dertleri ayıklıyor...");
            if (dert.Contains("Silah"))
            {
                return false;
            }
            return true;
        }

        public override ABasbakan DertDinle(string dert)
        {
            Console.WriteLine("vekil dert dinliyor...");
            if (DertAyır(dert))
            {
                Console.WriteLine("vekil dertleri basbakana iletiyor...");
                return aBasbakan.DertDinle(dert);
            }
            else
            {
                Console.WriteLine("***zararlı birey engellendi!***");
                return this;
            }

        }

        public override ABasbakan IsBul(string yakınım)
        {
            Console.WriteLine("vekil iş bulma yı iletiyor...");
            return aBasbakan.IsBul(yakınım);
        }
    }
}
