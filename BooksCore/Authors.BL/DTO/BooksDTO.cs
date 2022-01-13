using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.BL.DTO
{
    public class BooksDTO
    {
        public int IdBooks { get; set; }
        public string BookName { get; set; }
        public short YearOfPublication { get; set; }
        public int Editorial { get; set; }
        public int Author { get; set; }

        public virtual AuthorsDTO Authors { get; set; }
        public virtual EditorialsDTO Editorials { get; set; }
    }
}
