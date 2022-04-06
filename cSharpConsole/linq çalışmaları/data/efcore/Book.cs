using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.efcore
{
    public partial class Book
    {
        public Book()
        {
            Categorybooks = new HashSet<Categorybook>();
            Publisherbooks = new HashSet<Publisherbook>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<Categorybook> Categorybooks { get; set; }
        public virtual ICollection<Publisherbook> Publisherbooks { get; set; }
    }
}
