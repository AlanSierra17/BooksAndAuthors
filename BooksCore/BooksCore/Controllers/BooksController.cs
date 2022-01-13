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
    }
}
