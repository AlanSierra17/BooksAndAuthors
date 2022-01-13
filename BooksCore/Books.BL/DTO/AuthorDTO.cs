using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.DTO
{
    public class AuthorDTO
    {
        public int IdAuthors { get; set; }
        public string AuthorName { get; set; } = null!;
        public int Nationality { get; set; }

        public virtual DTO.NationalityDTO NationalityNavigation { get; set; } = null!;
    }
}
