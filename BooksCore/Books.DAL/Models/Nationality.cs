using System;
using System.Collections.Generic;

namespace Books.DAL.Models
{
    public partial class Nationality
    {
        public Nationality()
        {
            Authors = new HashSet<Author>();
        }

        public int IdNationalities { get; set; }
        public string Nationality1 { get; set; } = null!;

        public virtual ICollection<Author> Authors { get; set; }
    }
}
