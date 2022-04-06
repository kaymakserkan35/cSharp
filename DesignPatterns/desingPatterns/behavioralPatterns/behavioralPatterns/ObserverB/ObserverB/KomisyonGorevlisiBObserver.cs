using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverB
{
    class KomisyonGorevlisiBObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as EhliyetAdayıSubject).HataPuanı > 75)
            {
                Console.WriteLine("KomisyonGorevlisiB : hata puanın 50 yi geçti. aracı kenara yanastır. gecemedin...");
            }
        }
    }
}
