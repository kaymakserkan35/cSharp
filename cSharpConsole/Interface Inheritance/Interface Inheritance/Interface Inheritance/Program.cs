using System;

namespace Interface_Inheritance
{

    interface IRepository
    {
        void Crud();
        //string IsValid; interface tip alamaz yanlızca method imzaları
    }

    interface IProductRepository : IRepository
    {
        void Detail();
    }

    interface IProductService : IProductRepository
    { }
    interface IValidation
    {
        bool Validation();
    }
    public class ProductManager : IProductService, IValidation
    {
        public void Crud()
        { }

        public void Detail()
        {

        }

        public bool Validation()
        {
            return true;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            IProductService productService = new ProductManager();
            IValidation validation = new ProductManager();

            var pS = (ProductManager)productService;
            pS.Crud(); pS.Detail(); pS.Validation();

            var p = (IRepository)productManager;
             p.Crud();

        }
    }
}
