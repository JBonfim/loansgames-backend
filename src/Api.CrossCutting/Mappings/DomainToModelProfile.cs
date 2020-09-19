using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DomainToModelProfile : Profile
    {
        public DomainToModelProfile()
        {
             CreateMap<UserEntity, UserDto>()
                .ReverseMap();
            CreateMap<UserEntity, UserCreateDomainModel>()
                .ReverseMap();
            CreateMap<UserEntity, UserUpdateDomainModel>()
                .ReverseMap();
        }
    }
}