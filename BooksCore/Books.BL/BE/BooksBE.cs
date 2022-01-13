using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.BE
{
    public class BooksBE
    {
        public List<DTO.BookDTO> GetAll()
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperBook
                .Map<List<DTO.BookDTO>>(new Books.DAL.TE.BooksTE().ReadAll());

            return Map;
        }
    }
}
