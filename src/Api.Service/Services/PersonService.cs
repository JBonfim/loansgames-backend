using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Person;

namespace Api.Service.Services
{
    public class PersonService : IPersonService
    {
         private IRepository<PersonEntity> _repository;

         public PersonService(IRepository<PersonEntity> repository)
         {
             _repository = repository;
         }
        public async Task<bool> Delete(long id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<PersonEntity> Get(long id)
        {
            return  await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PersonEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PersonEntity> Post(PersonEntity person)
        {
            return await _repository.InsertAsync(person);
        }

        public async Task<PersonEntity> Put(PersonEntity person)
        {
            return await _repository.UpdateAsync(person);
        }
    }
}