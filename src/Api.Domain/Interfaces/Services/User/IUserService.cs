using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
         Task<UserDto> Get(long id);
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserResponseDomainModel> Post(UserCreateDomainModel user);
        Task<UserResponseDomainModel> Put(UserUpdateDomainModel user);
        Task<bool> Delete(long id);
    }
}