using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Publisher
    {
        public Publisher()
        {
            Publisherbooks = new HashSet<Publisherbook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Publisherbook> Publisherbooks { get; set; }
    }
}
