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
                    cfg.CreateMap<DTO.BookCreationAndEditDTO, DAL.Models.Book>()
                       .ForMember(dest => dest.EditorialNavigation, opt => opt.Ignore())
                       .ForMember(dest => dest.AuthorNavigation, opt => opt.Ignore());

                    cfg.CreateMap<DAL.Models.Book, DTO.BookDTO>();

                    cfg.CreateMap<DAL.Models.Author, DTO.AuthorDTO>();
                    cfg.CreateMap<DAL.Models.Editorial, DTO.EditorialDTO>();
                    cfg.CreateMap<DAL.Models.Nationality, DTO.NationalityDTO>();

                });

                return config.CreateMapper();

            }

        }

        public static AutoMapper.IMapper MapperNationalities
        {
            get
            {
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DTO.NationalitiesCreateAndEdit, DAL.Models.Nationality>()
                       .ForMember(dest => dest.Authors, opt => opt.Ignore());

                    cfg.CreateMap<DAL.Models.Nationality, DTO.NationalityDTO>();


                });

                return config.CreateMapper();

            }

        }
        public static AutoMapper.IMapper MapperEditorials
        {
            get
            {
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DTO.EditorialCreateAndEditDTO, DAL.Models.Editorial>()
                       .ForMember(dest => dest.Books, opt => opt.Ignore());

                    cfg.CreateMap<DAL.Models.Editorial, DTO.EditorialDTO>();


                });

                return config.CreateMapper();

            }

        }
    }
}
