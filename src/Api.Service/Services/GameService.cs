using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Game;

namespace Api.Service.Services
{
    public class GameService : IGameService
    {
        private IRepository<GameEntity> _repository;

        public GameService(IRepository<GameEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(long id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<GameEntity> Get(long id)
        {
            return  await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<GameEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<GameEntity> Post(GameEntity game)
        {
            return await _repository.InsertAsync(game);
        }

        public async Task<GameEntity> Put(GameEntity game)
        {
            return await _repository.UpdateAsync(game);
        }
    }
}