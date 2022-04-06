using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Categorybook
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
}
