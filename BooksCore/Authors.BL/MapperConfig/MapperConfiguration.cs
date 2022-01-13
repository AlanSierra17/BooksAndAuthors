using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.BL.MapperConfig
{
    public class MapperConfiguration
    {
        public static AutoMapper.IMapper MapperAuthors
        {
            get
            {
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DTO.AuthorsCreationAndEditDTO, DAL.Authors>()
                       .ForMember(dest => dest.Nationalities, opt => opt.Ignore())
                    ;
                    cfg.CreateMap<DAL.Authors, DTO.AuthorsDTO>();

                    cfg.CreateMap<DAL.Nationalities, DTO.NationalitiesDTO>();

                });

                return config.CreateMapper();

            }
        }
    }
}
