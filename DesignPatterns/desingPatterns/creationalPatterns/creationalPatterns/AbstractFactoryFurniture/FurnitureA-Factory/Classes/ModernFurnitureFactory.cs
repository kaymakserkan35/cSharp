using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureA_Factory.Classes
{
    public class ModernFurnitureFactory : AbstractFurnitureFactory
    {
        public override AbstractFurniture CreateChair()
        {
            return new ModernChair();
        }

        public override AbstractFurniture CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public override AbstractFurniture CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
