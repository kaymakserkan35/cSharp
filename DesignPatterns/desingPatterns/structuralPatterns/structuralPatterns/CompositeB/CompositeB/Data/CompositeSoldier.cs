using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeB.Data
{
    class CompositeSoldier : ASoldier
    {

        private List<ASoldier> soldiers = new List<ASoldier>();

        public CompositeSoldier(string name, SoldierRank rank) : base(name, rank)
        {
        }


        public override ASoldier AddSoldier(ASoldier soldier)
        {
            this.soldiers.Add(soldier);
            return this;
        }

        public override ASoldier RemoveSoldier(ASoldier soldier)
        {
            this.soldiers.Remove(soldier);
            return this;
        }
        public override ASoldier ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", rank, name));

            foreach (ASoldier soldier in soldiers)
            {
                soldier.ExecuteOrder();
        
            }

            return this;
        }

    }
}
