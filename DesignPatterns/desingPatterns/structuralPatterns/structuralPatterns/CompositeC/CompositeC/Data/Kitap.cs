using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeC.Data
{
    class Kitap : AKütüphane
    {
        public string KitapAdı { get; set; }
        public Kitap(string KitapAdı)
        {
            this.KitapAdı = KitapAdı;
        }
        public override void Goster()
        {
            Console.WriteLine($"*{KitapAdı}");
        }
    }
}
