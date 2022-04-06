using linq_çalışmaları.data.efcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace linq_çalışmaları
{
    public class bookModel { string title { get; set; } double price { get; set; } }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                /*----------bire çok ---------------*/
                var books1 = context.Books.Where(x => x.Author.FirstName == "Patricia").ToList();
                var books2 = context.Books.Include(x => x.Author).Where(x => x.Author.FirstName == "Patricia").ToList();
                var books3 = context.Books.Include(x => x.Author).Where(x => x.Price > 20).ToList();

                var books4_1 = context.Books.Include(x => x.Author).Where(x => x.Categorybooks.Any()).ToList();
                var books4 = context.Books.Include(x => x.Author).Where(x => !x.Categorybooks.Any()).ToList();
                var books5 = context.Books.Where(x => x.Price > 45)
                    .Include(x => x.Author).ThenInclude(x => x.Adresses)
                    .Select(x => new { x.Title, x.Author.FirstName, x.Author.Adresses })
                    .ToList();


                var books6 = context.Books.Include(x => x.Author).ThenInclude(x => x.Adresses).ToList();


                Console.WriteLine("");

            }



        }
    }
}
