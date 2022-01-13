using System;
using System.Collections.Generic;

namespace Books.DAL.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int IdAuthors { get; set; }
        public string AuthorName { get; set; } = null!;
        public int Nationality { get; set; }

        public virtual Nationality NationalityNavigation { get; set; } = null!;
        public virtual ICollection<Book> Books { get; set; }
    }
}
