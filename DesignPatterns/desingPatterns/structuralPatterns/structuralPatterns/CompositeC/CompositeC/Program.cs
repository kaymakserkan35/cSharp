using CompositeC.Data;
using System;

namespace CompositeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Kategori kitaplar = new Kategori("Kitap");
            Kategori bilimkurgu = new Kategori("BilimKurgu");
            Kategori fantastik = new Kategori("Fantastik");

            Kitap kitap1 = new Kitap("kuyucaklı");
            Kitap kitap2 = new Kitap("suç ve ceza");
            Kitap kitap3 = new Kitap("Dünyanın Sonu");
            Kitap kitap4 = new Kitap("yüzüklerin efendisi");

            kitaplar.Ekle(kitap1);
            kitaplar.Ekle(kitap2);
            bilimkurgu.Ekle(kitap3);
            kitaplar.Goster();
            bilimkurgu.Goster();
            fantastik.Ekle(kitap4);

        }
    }
}
