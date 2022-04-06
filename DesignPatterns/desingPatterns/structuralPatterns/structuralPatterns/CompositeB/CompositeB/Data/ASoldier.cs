using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeB.Data
{
    abstract class ASoldier
    {
        protected string name;
        protected SoldierRank rank;
        public ASoldier(string name, SoldierRank rank)
        {
            this.name = name;
            this.rank = rank;
        }


        public virtual ASoldier AddSoldier(ASoldier soldier) { return this; }
        public abstract ASoldier RemoveSoldier(ASoldier soldier);
        //Hem Leaf hemde Composite tipi için uygulanacak olan fonksiyon
        public abstract ASoldier ExecuteOrder();
    }
}
