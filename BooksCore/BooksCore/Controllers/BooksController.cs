using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooksCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public List<Books.BL.DTO.BookDTO> GetAll()
        {
            List<Books.BL.DTO.BookDTO> res = new List<Books.BL.DTO.BookDTO>();

            res = new Books.BL.BE.BooksBE().GetAll();

            return res;

        }

        // GET 
        [HttpGet("{id}")]
        public Books.BL.DTO.BookDTO GetOne(int id)
        {

            Books.BL.DTO.BookDTO res = new Books.BL.BE.BooksBE().GetOne(id);

            return res;
        }

        // POST 
        [HttpPost]
        public void PostBook([FromBody] Books.BL.DTO.BookCreationAndEditDTO BookToPost)
        {
            new Books.BL.BE.BooksBE().CreateBook(BookToPost);

        }


        // PUT 
        [HttpPut]
        public void PutBook([FromBody] Books.BL.DTO.BookCreationAndEditDTO BookToEdit)
        {
            new Books.BL.BE.BooksBE().EditBook(BookToEdit);
        }

        //DELETE 
        [HttpDelete]
        public void DeleteBook(int IdBook)
        {
            new Books.BL.BE.BooksBE().DeleteBook(IdBook);
        }
    }
}
