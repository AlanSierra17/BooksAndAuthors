using System;
using System.Collections.Generic;

namespace Books.DAL.Models
{
    public partial class Editorial
    {
        public Editorial()
        {
            Books = new HashSet<Book>();
        }

        public int IdEditorials { get; set; }
        public string EditorialName { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
