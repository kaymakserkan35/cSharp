using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverB
{
    class KomisyonGorevlisiAObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as EhliyetAdayıSubject).car.Hız > 50)
            {
                Console.WriteLine("KomisyonGorevlisiA : Çok Hızlandın yavaşla biraz...");
            }
        }
    }
}
