using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureA_Factory.Classes
{
    public abstract class AbstractFurnitureFactory
    {
        public abstract AbstractFurniture CreateChair();
        public abstract AbstractFurniture CreateSofa();
        public abstract AbstractFurniture CreateCoffeeTable();
    }
}
