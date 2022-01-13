using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiBooksCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialsController : ControllerBase
    {
        [HttpGet]
        public List<Books.BL.DTO.EditorialDTO> GetAll()
        {
            List<Books.BL.DTO.EditorialDTO> res = new List<Books.BL.DTO.EditorialDTO>();

            res = new Books.BL.BE.EditorialsBE().GetAll();

            return res;

        }

        // GET 
        [HttpGet("{id}")]
        public Books.BL.DTO.EditorialDTO GetOne(int id)
        {

            Books.BL.DTO.EditorialDTO res = new Books.BL.BE.EditorialsBE().GetOne(id);

            return res;
        }

        // POST 
        [HttpPost]
        public void PostEditorial([FromBody] Books.BL.DTO.EditorialCreateAndEditDTO EditorialToPost)
        {
            new Books.BL.BE.EditorialsBE().CreateEditorial(EditorialToPost);

        }

        // PUT 
        [HttpPut]
        public void PutEditorial([FromBody] Books.BL.DTO.EditorialCreateAndEditDTO EditorialToEdit)
        {
            new Books.BL.BE.EditorialsBE().EditEditorial(EditorialToEdit);
        }

        //DELETE 
        [HttpDelete]
        public void DeleteEditorial(int IdEditorial)
        {
            new Books.BL.BE.EditorialsBE().DeleteEditorial(IdEditorial);
        }
    }
}
