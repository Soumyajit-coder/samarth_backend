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
            CreateMap<Permission, PermissionListDTO>()
            .ForMember(dest => dest.IsActive, opt =>
                opt.MapFrom(src => src.IsActive == 1 ? "Active" : "Inactive"))
            .ReverseMap()
            .ForMember(dest => dest.IsActive, opt =>
                opt.MapFrom(src => src.IsActive == "Active" ? 1 : 0));
            CreateMap<Permission, AddPermissionDTO>().ReverseMap();
            CreateMap<Permission, updatePermissionDTO>().ReverseMap();
            CreateMap<Role, RoleMgmtListDTO>().ForMember(dest => dest.IsActive, opt =>
                opt.MapFrom(src => src.IsActive == 1 ? "Active" : "Inactive"))
            .ReverseMap()
            .ForMember(dest => dest.IsActive, opt =>
                opt.MapFrom(src => src.IsActive == "Active" ? 1 : 0));
            CreateMap<Role, RoleMgmtDTO>().ReverseMap();
            CreateMap<Role, UpdateRoleDetailsDTO>().ReverseMap();
        }
    }
}
