using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Game;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Game
{
    public interface IGameService
    {
          Task<GameResponseDomainModel> Get(long id);
        Task<IEnumerable<GameResponseDomainModel>> GetAll();
        Task<GameResponseDomainModel> Post(GameCreateDomainModel game);
        Task<GameResponseDomainModel> Put(GameUpdateDomainModel game);
        Task<bool> Delete(long id);
    }
}