using System;

namespace CommandD
{
    class Program
    {
        static void Main(string[] args)
        {
            SiparisEkleKomutu siparisEkleKomutu = new SiparisEkleKomutu(new SiparisIslemleri());
            SiparisGuncellemeKomutu siparisGuncellemeKomutu = new SiparisGuncellemeKomutu(new SiparisIslemleri());

            VeritabaniKomutIletici veritabaniIslemcisi = new VeritabaniKomutIletici();


            veritabaniIslemcisi.Calistir(siparisEkleKomutu);
            veritabaniIslemcisi.Calistir(siparisGuncellemeKomutu);

            Console.ReadLine();
        }
    }
}
