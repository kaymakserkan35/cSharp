using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeC.Data
{
    class Kategori : AKütüphane
    {
        public string Ad { get; set; }
        public Kategori(string ad)
        {
            Ad = ad;
        }

        private List<AKütüphane> altOgeler = new List<AKütüphane>();
        public void Ekle(AKütüphane kütüphane)
        {
            altOgeler.Add(kütüphane);
        }
        public override void Goster( )
        {
            foreach (var oge in altOgeler)
            {
                oge.Goster();
            }
        }
    }
}
