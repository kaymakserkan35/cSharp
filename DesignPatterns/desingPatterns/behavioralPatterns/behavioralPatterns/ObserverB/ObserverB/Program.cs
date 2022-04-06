using System;

namespace ObserverB
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new EhliyetAdayıSubject();
            var observerA = new KomisyonGorevlisiAObserver();
            subject.Attach(observerA);

            var observerB = new KomisyonGorevlisiBObserver();
            subject.Attach(observerB);

            subject.Hızlan();
            subject.Hızlan();
            subject.Hızlan();
            subject.Yavaşla();
            subject.KırmızıIsıktaGec();
            subject.AracıÇarp();
            subject.Yavaşla();
            subject.Yavaşla();

        }
    }
}
