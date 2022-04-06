using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Adress
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        

        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
