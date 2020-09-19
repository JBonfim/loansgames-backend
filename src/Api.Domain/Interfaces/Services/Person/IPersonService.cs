using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Person;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Person
{
    public interface IPersonService
    {
        Task<PersonResponseDomainModel> Get(long id);
        Task<IEnumerable<PersonResponseDomainModel>> GetAll();
        Task<PersonResponseDomainModel> Post(PersonCreateDomainModel person);
        Task<PersonResponseDomainModel> Put(PersonUpdateDomainModel person);
        Task<bool> Delete(long id);
    }
}