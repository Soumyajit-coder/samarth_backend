using AutoMapper;
using samarth_backend.DAL.Entities;
using samarth_backend.DTO;

namespace samarth_backend.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserLoginDTO>().ReverseMap();
            CreateMap<User, UserForgetPasswordDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
