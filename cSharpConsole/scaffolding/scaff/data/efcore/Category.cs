using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Category
    {
        public Category()
        {
            Categorybooks = new HashSet<Categorybook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Categorybook> Categorybooks { get; set; }
    }
}
