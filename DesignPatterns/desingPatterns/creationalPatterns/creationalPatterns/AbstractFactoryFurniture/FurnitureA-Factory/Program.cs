using FurnitureA_Factory.Classes;
using System;

namespace FurnitureA_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VictorianFurnitureFactory victorianFurnitureFactory = new VictorianFurnitureFactory();
            victorianFurnitureFactory.CreateChair();
            victorianFurnitureFactory.CreateCoffeeTable();
            victorianFurnitureFactory.CreateSofa();
        }
    }
}
