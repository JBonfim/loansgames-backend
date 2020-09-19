using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Game
{
    public interface IGameService
    {
          Task<GameEntity> Get(long id);
        Task<IEnumerable<GameEntity>> GetAll();
        Task<GameEntity> Post(GameEntity game);
        Task<GameEntity> Put(GameEntity game);
        Task<bool> Delete(long id);
    }
}