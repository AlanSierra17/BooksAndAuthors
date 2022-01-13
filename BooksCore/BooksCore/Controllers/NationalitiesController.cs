using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooksCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitiesController : ControllerBase
    {
        [HttpGet]
        public List<Books.BL.DTO.NationalityDTO> GetAll()
        {
            List<Books.BL.DTO.NationalityDTO> res = new List<Books.BL.DTO.NationalityDTO>();

            res = new Books.BL.BE.NationalitiesBE().GetAll();

            return res;

        }

        // GET 
        [HttpGet("{id}")]
        public Books.BL.DTO.NationalityDTO GetOne(int id)
        {

            Books.BL.DTO.NationalityDTO res = new Books.BL.BE.NationalitiesBE().GetOne(id);

            return res;
        }

        // POST 
        [HttpPost]
        public void PostNation([FromBody] Books.BL.DTO.NationalitiesCreateAndEdit NationToPost)
        {
            new Books.BL.BE.NationalitiesBE().CreateNation(NationToPost);

        }

        // PUT 
        [HttpPut]
        public void PutNation([FromBody] Books.BL.DTO.NationalitiesCreateAndEdit NationToEdit)
        {
            new Books.BL.BE.NationalitiesBE().EditNation(NationToEdit);
        }

        //DELETE 
        [HttpDelete]
        public void DeleteNation(int IdNation)
        {
            new Books.BL.BE.NationalitiesBE().DeleteNation(IdNation);
        }
    }
}
