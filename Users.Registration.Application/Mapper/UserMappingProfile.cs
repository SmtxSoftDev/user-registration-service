using AutoMapper;
using Users.Registration.Application.Dto.Users;
using Users.Registration.Domain.Entities.Users;

namespace Users.Registration.Application.Mapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserData, UserDataDto>().ReverseMap();
        }
    }
}