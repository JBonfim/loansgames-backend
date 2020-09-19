using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Person
{
    public interface IPersonService
    {
           Task<PersonEntity> Get(long id);
        Task<IEnumerable<PersonEntity>> GetAll();
        Task<PersonEntity> Post(PersonEntity person);
        Task<PersonEntity> Put(PersonEntity person);
        Task<bool> Delete(long id);
    }
}