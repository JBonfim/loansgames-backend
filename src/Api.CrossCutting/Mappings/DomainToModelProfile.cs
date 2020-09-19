using Api.Domain.Dtos.Game;
using Api.Domain.Dtos.GamePersonalLoan;
using Api.Domain.Dtos.Person;
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

              CreateMap<GameEntity, GameCreateDomainModel>()
                .ReverseMap();
            CreateMap<GameEntity, GameUpdateDomainModel>()
                .ReverseMap();

             CreateMap<PersonEntity, PersonCreateDomainModel>()
                .ReverseMap();
            CreateMap<PersonEntity, PersonUpdateDomainModel>()
                .ReverseMap();

             CreateMap<GamePersonalLoanEntity, GamePersonLoanCreateDomainModel>()
                .ReverseMap();
            CreateMap<GamePersonalLoanEntity, GamePersonLoanUpdateDomainModel>()
                .ReverseMap();
        }
    }
}