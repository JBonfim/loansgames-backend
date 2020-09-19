using Api.Domain.Dtos.Game;
using Api.Domain.Dtos.GamePersonalLoan;
using Api.Domain.Dtos.Person;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDomainProfile : Profile
    {
        public EntityToDomainProfile()
        {
            CreateMap<UserDto, UserEntity>()
               .ReverseMap();

            CreateMap<UserResponseDomainModel, UserEntity>()
               .ReverseMap();

            CreateMap<GameResponseDomainModel, GameEntity>()
            .ReverseMap();

            CreateMap<PersonResponseDomainModel, PersonEntity>()
            .ReverseMap();

             CreateMap<GamePersonResponseView, GamePersonalLoanEntity>()
            .ReverseMap();


            
        }
    }
}