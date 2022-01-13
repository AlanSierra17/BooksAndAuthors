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


        public DTO.BookDTO GetOne(int IdBook)
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperBook
                    .Map<DTO.BookDTO>(new Books.DAL.TE.BooksTE().ReadOne(IdBook));

            return Map;
        }

        public void CreateBook(DTO.BookCreationAndEditDTO BookToCreate)
        {
            new DAL.TE.BooksTE().CreateBook(MapperConfig.MapperConfiguration.MapperBook.Map<DAL.Models.Book>(BookToCreate));
        }

        public void EditBook(DTO.BookCreationAndEditDTO BookToEdit)
        {
            new DAL.TE.BooksTE().EditBook(MapperConfig.MapperConfiguration.MapperBook.Map<DAL.Models.Book>(BookToEdit));
        }

        public void DeleteBook(int IdBook)
        {
            new Books.DAL.TE.BooksTE().DeleteBook(IdBook);
        }
    }
}
