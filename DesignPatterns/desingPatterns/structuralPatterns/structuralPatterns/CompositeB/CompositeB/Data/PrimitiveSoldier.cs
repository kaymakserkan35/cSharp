using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeB.Data
{
    class PrimitiveSoldier : ASoldier
    {
        public PrimitiveSoldier(string name, SoldierRank rank) : base(name, rank)
        {
        }


        // Bu fonksiyonun Leaf için anlamı yoktur. o zaman bu sınıf bu methodları görmemeli ama görüyor ==> interface sepegareteion a aykırı bir durum!!
        //public override ASoldier AddSoldier(ASoldier soldier)
        //{
        //    throw new NotImplementedException();
        //}
        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override ASoldier RemoveSoldier(ASoldier soldier)
        {
            throw new NotImplementedException();
        }

        public override ASoldier ExecuteOrder()
        {
            Console.WriteLine(string.Format("{0}{1}", rank, name));
            return this;
        }

    }
}
