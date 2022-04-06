using CompositeB.Data;
using System;

namespace CompositeB
{
    class Program
    {
        static void Main(string[] args)
        {


            // Root oluşturulur.   
            CompositeSoldier generalCagatay = new CompositeSoldier("cagatay", SoldierRank.General);


            // root altına Leaf tipten nesne örnekleri eklenir.
            generalCagatay.AddSoldier(new PrimitiveSoldier("Mayk", SoldierRank.Colonel));
            generalCagatay.AddSoldier(new PrimitiveSoldier("Tobiassen", SoldierRank.Colonel));


            // Composite tipler oluşturulur.
            CompositeSoldier colonelNevi = new CompositeSoldier("Nevi", SoldierRank.Colonel);
            CompositeSoldier lieutenantColonelZing = new CompositeSoldier("Zing", SoldierRank.LieutenantColonel);


            // Composite tipe bağlı primitive tipler oluşturulur.
            lieutenantColonelZing.AddSoldier(new PrimitiveSoldier("Tomasson", SoldierRank.Captain));
            colonelNevi.AddSoldier(lieutenantColonelZing);
            colonelNevi.AddSoldier(new PrimitiveSoldier("Mayro", SoldierRank.LieutenantColonel));

            // Root' un altına Composite nesne örneği eklenir.
            generalCagatay.AddSoldier(colonelNevi);


            generalCagatay.AddSoldier(new PrimitiveSoldier("Zulu", SoldierRank.Colonel));


            // root için ExecuteOrder operasyonu uygulanır. Buna göre root altındaki tüm nesneler için bu operasyon uygulanır
            generalCagatay.ExecuteOrder();


        }
    }
}
