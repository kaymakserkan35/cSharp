using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureA_Factory.Classes
{
    public class ArtDecoFurnitureFactory : AbstractFurnitureFactory
    {
        public override AbstractFurniture CreateChair()
        {
            return new ArtDecoChair();
        }

        public override AbstractFurniture CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public override AbstractFurniture CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
