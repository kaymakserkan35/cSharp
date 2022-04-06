using System;
using System.Collections.Generic;

namespace delegeler
{
    public class Personel
    {
        public int Id { get; set; }
        public int Maaş { get; set; }
        public int Tecrube { get; set; }


        public delegate bool Zamdelegate(Personel p);


        public static List<Personel> ZamMethod(List<Personel> personels, Zamdelegate zamdelegate)
        {
            List<Personel> _personels = new List<Personel>();
            foreach (var p in personels)
            {
                if (zamdelegate(p))
                {
                    _personels.Add(p);
                }
            }

            return _personels;
        }
    }




    class Program
    {

        static void Main(string[] args)
        {
            var p1 = new Personel() { Id = 1, Maaş = 1000, Tecrube = 80 };
            var p2 = new Personel() { Id = 1, Maaş = 1000, Tecrube = 60 };
            var p3 = new Personel() { Id = 1, Maaş = 1000, Tecrube = 40 };
            List<Personel> personels = new List<Personel>();
            personels.Add(p1); personels.Add(p2); personels.Add(p3);

            var result = Personel.ZamMethod(personels, x => x.Tecrube > 50);
            Console.WriteLine();

        }
    }
}
