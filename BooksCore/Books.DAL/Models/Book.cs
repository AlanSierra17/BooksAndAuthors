using System;
using System.Collections.Generic;

namespace Books.DAL.Models
{
    public partial class Book
    {
        public int IdBooks { get; set; }
        public string BookName { get; set; } = null!;
        public short YearOfPublication { get; set; }
        public int Editorial { get; set; }
        public int Author { get; set; }

        public virtual Author AuthorNavigation { get; set; } = null!;
        public virtual Editorial EditorialNavigation { get; set; } = null!;
    }
}
