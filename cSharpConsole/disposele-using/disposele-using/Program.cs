using System;
using System.IO;

namespace disposele_using
{

    class Sinif
    {
        public Sinif()
        {
            Console.WriteLine("Nesne oluşturuldu.");
        }

        ~Sinif()
        {
            Console.WriteLine("Kullanılan kaynaklar silindi.");
        }


    }

    class SinifB : IDisposable
    {
        private FileStream DosyaIslemleri = null;
        public SinifB()
        {
            DosyaIslemleri = new FileStream("dosyaYolu", FileMode.OpenOrCreate);
        }

        ~SinifB() //yıkıcı method en son çalıştırılan method!
        {
            Console.WriteLine("Kullanılan kaynaklar silindi.");
            DosyaIslemleri.Close();
            DosyaIslemleri = null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sinif s1 = new Sinif();
            Console.WriteLine("Uzun süren bir işlem.");
        }
    }





}
