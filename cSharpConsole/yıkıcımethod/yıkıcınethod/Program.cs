using System;

namespace yıkıcınethod
{
    public class Ogrenci
    {
        public Ogrenci()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }


        ~Ogrenci()
        {
            Console.WriteLine("Yıkıcı metot çalıştı.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Uygulama başladı.");
            Ogrenci yeniOgrenci = new Ogrenci();
            Console.WriteLine("Öğrenci nesnesi oluştu.");

            Console.WriteLine("Uygulama bitti.");
            Console.ReadLine();
        }
    }
}
