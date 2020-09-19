using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.GamePersonalLoan;

namespace Api.Service.Services
{
    public class GamePersonalLoanService : IGamePersonalLoanService
    {
         private IRepository< GamePersonalLoanEntity> _repository;

         public GamePersonalLoanService(IRepository< GamePersonalLoanEntity> repository)
         {
             _repository = repository;
         }

        public async Task<bool> Delete(long id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<GamePersonalLoanEntity> Get(long id)
        {
             return  await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<GamePersonalLoanEntity>> GetAll()
        {
             return await _repository.SelectAsync();
        }

        public async Task<GamePersonalLoanEntity> Post(GamePersonalLoanEntity GamePersonal)
        {
             return await _repository.InsertAsync(GamePersonal);
        }

        public async Task<GamePersonalLoanEntity> Put(GamePersonalLoanEntity GamePersonal)
        {
            return await _repository.UpdateAsync(GamePersonal);
        }
    }
}