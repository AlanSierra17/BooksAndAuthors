using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.BE
{
    public class NationalitiesBE
    {
        public List<DTO.NationalityDTO> GetAll()
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperNationalities
                .Map<List<DTO.NationalityDTO>>(new Books.DAL.TE.NationalitiesTE().ReadAll());

            return Map;
        }


        public DTO.NationalityDTO GetOne(int IdNation)
        {
            var Map = Books.BL.MapperConfig.MapperConfiguration.MapperNationalities
                    .Map<DTO.NationalityDTO>(new Books.DAL.TE.NationalitiesTE().ReadOne(IdNation));

            return Map;
        }

        public void CreateNation(DTO.NationalitiesCreateAndEdit NationToCreate)
        {
            new DAL.TE.NationalitiesTE().CreateNation(MapperConfig.MapperConfiguration.MapperNationalities.Map<DAL.Models.Nationality>(NationToCreate));
        }

        public void EditNation(DTO.NationalitiesCreateAndEdit NationToEdit)
        {
            new DAL.TE.NationalitiesTE().EditNation(MapperConfig.MapperConfiguration.MapperNationalities.Map<DAL.Models.Nationality>(NationToEdit));
        }

        public void DeleteNation(int IdNation)
        {
            new Books.DAL.TE.NationalitiesTE().DeleteNation(IdNation);
        }
    }
}
