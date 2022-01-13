using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAuthorsFramework.Controllers
{
    public class AuthorsController : ApiController
    {
        // GET: api/Authors
        [HttpGet]
        public List<Authors.BL.DTO.AuthorsDTO> GetAll()
        {
            List<Authors.BL.DTO.AuthorsDTO> res = new List<Authors.BL.DTO.AuthorsDTO>();

            res = new Authors.BL.BE.AuthorsBE().GetAll();

            return res;

        }

        // GET: api/Authors/5
        [HttpGet]
        public Authors.BL.DTO.AuthorsDTO GetOne(int id)
        {
            //Books.BL.DTO.BookDTO res = new Books.BL.DTO.BookDTO;

            Authors.BL.DTO.AuthorsDTO res = new Authors.BL.BE.AuthorsBE().GetOne(id);

            return res;
        }

        // POST: api/Authors
        [HttpPost]
        public void PostBook([FromBody] Authors.BL.DTO.AuthorsCreationAndEditDTO AuthorToPost)
        {
            new Authors.BL.BE.AuthorsBE().CreateAuthor(AuthorToPost);

        }

        // PUT: api/Authors/5
        [HttpPut]
        public void putBook([FromBody] Authors.BL.DTO.AuthorsCreationAndEditDTO AuthorToEdit)
        {
            new Authors.BL.BE.AuthorsBE().EditAuthor(AuthorToEdit);
        }

        // DELETE: api/Authors/5

        [HttpDelete]
        public void DeleteAuthor(int id)
        {
            new Authors.BL.BE.AuthorsBE().DeleteAuthor(id);
        }
    }
}
