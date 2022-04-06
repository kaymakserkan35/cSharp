using System;

namespace dependency_injection_and_services
{
    public class Context { public void method() { Console.WriteLine("context.books"); } }


    /*--------------------------------------------*/
    public class DbContext
    {
        private Context context;

        public DbContext(Context context)
        {
            this.context = context;
        }
    }


    public class LibraryContext : DbContext
    {
        public LibraryContext(Context context) : base(context)
        {
        }
    }

    /*--------------------------------------------*/


    public class EfGenericRepository
    {
        protected DbContext context;

        public EfGenericRepository(DbContext context)
        {
            this.context = context;
        }
    }


    public class ProductRepository : EfGenericRepository
    {
        public ProductRepository(LibraryContext context) : base(context)
        {
        }
        private LibraryContext Context { get => context as LibraryContext; }
    }
    /*--------------------------------------------*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
