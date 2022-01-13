using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.BL.DTO
{
    public class AuthorsCreationAndEditDTO
    {
        public int IdAuthors { get; set; }
        public string AuthorName { get; set; }
        public int Nationality { get; set; }
    }
}
