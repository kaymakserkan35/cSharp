using Proxy_Vekil_Pattern1.Classes;
using System;

namespace Proxy_Vekil_Pattern1
{
    class UnitTest
    {
        static void Main(string[] args)
        {
            Birey birey = new Birey("ayşeNine", "dizlerimağrıyor", "torunum işsiz");



            ABasbakan basbakan = new Basbakan();
            ABasbakan vekil = new VekilBasbakan(basbakan);


            vekil.DertDinle(birey.Dert);
            vekil.IsBul(birey.Yakınım);


            /*-----------------------*/
            var nedondumerakettim = vekil.DertDinle(birey.Dert);

        }
    }
}
