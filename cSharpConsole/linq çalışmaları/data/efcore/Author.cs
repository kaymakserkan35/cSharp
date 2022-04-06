using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Author
    {
        public Author()
        {
            Adresses = new HashSet<Adress>();
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
