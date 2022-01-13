using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BL.MapperConfig
{
    public class MapperConfiguration
    {
        public static AutoMapper.IMapper MapperBook
        {
            get
            {
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DTO.BookDTO, DAL.Models.Book>()
                       //.ForMember(dest => dest.Continente, opt => opt.Ignore());
                       ;
                    cfg.CreateMap<DAL.Models.Book, DTO.BookDTO>();

                    cfg.CreateMap<DAL.Models.Author, DTO.AuthorDTO>();
                    cfg.CreateMap<DAL.Models.Editorial, DTO.EditorialDTO>();
                    cfg.CreateMap<DAL.Models.Nationality, DTO.NationalityDTO>();

                });

                return config.CreateMapper();

            }
        }
    }
}
