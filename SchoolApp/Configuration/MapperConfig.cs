using AutoMapper;
using SchoolApp.Data;

namespace SchoolApp.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, DTO.UserReadOnlyDTO>().ReverseMap();

        }

    }
}
