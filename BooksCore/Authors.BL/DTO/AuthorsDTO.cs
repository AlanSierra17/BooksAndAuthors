using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.BL.DTO
{
    public class AuthorsDTO
    {
        public int IdAuthors { get; set; }
        public string AuthorName { get; set; }
        public int Nationality { get; set; }

        public virtual NationalitiesDTO Nationalities { get; set; }
        public virtual ICollection<BooksDTO> Books { get; set; }
    }
}
