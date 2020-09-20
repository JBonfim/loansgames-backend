using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.GamePersonalLoan;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.GamePersonalLoan;
using AutoMapper;

namespace Api.Service.Services
{
    public class GamePersonalLoanService : IGamePersonalLoanService
    {
         private IGamePersonalLoanRepository _repository;
         private readonly IMapper _mapper;
         public GamePersonalLoanService(IGamePersonalLoanRepository repository
          , IMapper mapper)
         {
             _repository = repository;
               _mapper = mapper;
         }

        public async Task<bool> Delete(long id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<GamePersonResponseView> Get(long id)
        {
              GamePersonalLoanEntity entity =  await _repository.FirstOrDefaultAsync(id);
              
              var result = _mapper.Map<GamePersonResponseView>(entity) ?? new GamePersonResponseView();

              return result;
        }

        public async Task<IEnumerable<GamePersonResponseView>> GetAll()
        {
               var listEntity = await _repository.SelectAllAsync();
               
               return _mapper.Map<IEnumerable<GamePersonResponseView>>(listEntity);
        }

        public async Task<GamePersonResponseView> Post(GamePersonLoanCreateDomainModel GamePersonal)
        {
             var entity = _mapper.Map<GamePersonalLoanEntity>(GamePersonal);
             var result =  await _repository.InsertAsync(entity);
             return await Get(result.Id);
        }

        public async Task<GamePersonResponseView> Put(GamePersonLoanUpdateDomainModel GamePersonal)
        {
             var entity = _mapper.Map<GamePersonalLoanEntity>(GamePersonal);
             var result =  await _repository.UpdateAsync(entity);
            return await Get(result.Id);
        }

        public async Task<IEnumerable<GamePersonResponseView>> SelectAllAsyncIsStatusIsActive(){
              
              var listEntity = await _repository.SelectAllAsyncIsStatusIsActive();
               
               return _mapper.Map<IEnumerable<GamePersonResponseView>>(listEntity);
        }
    }
}