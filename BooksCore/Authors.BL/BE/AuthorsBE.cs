using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.BL.BE
{
    public class AuthorsBE
    {
        public List<DTO.AuthorsDTO> GetAll()
        {
            var Map = Authors.BL.MapperConfig.MapperConfiguration.MapperAuthors
                .Map<List<DTO.AuthorsDTO>>(new Authors.DAL.TE.AuthorsTE().ReadAll());

            return Map;
        }


        public DTO.AuthorsDTO GetOne(int IdBook)
        {
            var Map = Authors.BL.MapperConfig.MapperConfiguration.MapperAuthors
                    .Map<DTO.AuthorsDTO>(new Authors.DAL.TE.AuthorsTE().ReadOne(IdBook));

            return Map;
        }

        public void CreateAuthor(DTO.AuthorsCreationAndEditDTO AuthorToCreate)
        {
            new DAL.TE.AuthorsTE().CreateAuthor(MapperConfig.MapperConfiguration.MapperAuthors.Map<DAL.Authors>(AuthorToCreate));
        }

        public void EditAuthor(DTO.AuthorsCreationAndEditDTO AuthorToEdit)
        {
            new DAL.TE.AuthorsTE().EditAuthors(MapperConfig.MapperConfiguration.MapperAuthors.Map<DAL.Authors>(AuthorToEdit));
        }

        public void DeleteAuthor(int IdAuthor)
        {
            new Authors.DAL.TE.AuthorsTE().DeleteAuthor(IdAuthor);
        }
    }
}
