using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Game;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Game;
using AutoMapper;

namespace Api.Service.Services
{
    public class GameService : IGameService
    {
        private IRepository<GameEntity> _repository;
           private readonly IMapper _mapper;

        public GameService(IRepository<GameEntity> repository, IMapper mapper)
        {
            _repository = repository;
             _mapper = mapper;
        }

        public async Task<bool> Delete(long id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<GameResponseDomainModel> Get(long id)
        {
              var entity = await _repository.SelectAsync(id);
            return _mapper.Map<GameResponseDomainModel>(entity) ?? new GameResponseDomainModel();
        }

        public async Task<IEnumerable<GameResponseDomainModel>> GetAll()
        {
           var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<GameResponseDomainModel>>(listEntity);
        }

        public async Task<GameResponseDomainModel> Post(GameCreateDomainModel game)
        {
             var entity = _mapper.Map<GameEntity>(game);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<GameResponseDomainModel>(result);
        }

        public async Task<GameResponseDomainModel> Put(GameUpdateDomainModel game)
        {
            var entity = _mapper.Map<GameEntity>(game);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<GameResponseDomainModel>(result);
        }
    }
}