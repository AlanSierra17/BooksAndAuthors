using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.DTO
{
    public class BookCreationAndEditDTO
    {
        public int IdBooks { get; set; }
        public string BookName { get; set; } = null!;
        public short YearOfPublication { get; set; }
        public int Editorial { get; set; }
        public int Author { get; set; }
    }
}
