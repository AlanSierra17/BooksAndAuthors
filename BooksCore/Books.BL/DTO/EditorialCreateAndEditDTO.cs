using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.DTO
{
    public class EditorialCreateAndEditDTO
    {
        public int IdEditorials { get; set; }
        public string EditorialName { get; set; } = null!;
    }
}
