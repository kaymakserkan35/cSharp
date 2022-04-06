using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureA_Factory.Classes
{
    public class VictorianFurnitureFactory : AbstractFurnitureFactory
    {
        public override AbstractFurniture CreateChair()
        {
            return new VictorianChair();
        }

        public override AbstractFurniture CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public override AbstractFurniture CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
