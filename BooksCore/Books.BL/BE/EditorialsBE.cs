using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.BE
{
    public class EditorialsBE
    {
        public List<DTO.EditorialDTO> GetAll()
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperEditorials
                .Map<List<DTO.EditorialDTO>>(new Books.DAL.TE.EditorialsTE().ReadAll());

            return Map;
        }


        public DTO.EditorialDTO GetOne(int IdEditorial)
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperEditorials
                    .Map<DTO.EditorialDTO>(new Books.DAL.TE.EditorialsTE().ReadOne(IdEditorial));

            return Map;
        }

        public void CreateEditorial(DTO.EditorialCreateAndEditDTO EditorialToCreate)
        {
            new DAL.TE.EditorialsTE().CreateEditorial(MapperConfig.MapperConfiguration.MapperEditorials.Map<DAL.Models.Editorial>(EditorialToCreate));
        }

        public void EditEditorial(DTO.EditorialCreateAndEditDTO EditoralToEdit)
        {
            new DAL.TE.EditorialsTE().EditEditorial(MapperConfig.MapperConfiguration.MapperEditorials.Map<DAL.Models.Editorial>(EditoralToEdit));
        }

        public void DeleteEditorial(int IdEditorial)
        {
            new Books.DAL.TE.EditorialsTE().DeleteEditoral(IdEditorial);
        }
    }
}
