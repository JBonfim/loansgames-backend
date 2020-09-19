using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Person;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Person;
using AutoMapper;

namespace Api.Service.Services
{
    public class PersonService : IPersonService
    {
         private IRepository<PersonEntity> _repository;
           private readonly IMapper _mapper;

         public PersonService(IRepository<PersonEntity> repository
                            , IMapper mapper)
         {
             _repository = repository;
              _mapper = mapper;
         }
        public async Task<bool> Delete(long id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<PersonResponseDomainModel> Get(long id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PersonResponseDomainModel>(entity) ?? new PersonResponseDomainModel();
        }

        public async Task<IEnumerable<PersonResponseDomainModel>> GetAll()
        {
           var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PersonResponseDomainModel>>(listEntity);
        }

        public async Task<PersonResponseDomainModel> Post(PersonCreateDomainModel person)
        {
              var entity = _mapper.Map<PersonEntity>(person);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PersonResponseDomainModel>(result);
        }

        public async Task<PersonResponseDomainModel> Put(PersonUpdateDomainModel person)
        {
           var entity = _mapper.Map<PersonEntity>(person);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PersonResponseDomainModel>(result);
        }
    }
}