using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.GamePersonalLoan
{
    public interface IGamePersonalLoanService
    {
        Task<GamePersonalLoanEntity> Get(long id);
        Task<IEnumerable<GamePersonalLoanEntity>> GetAll();
        Task<GamePersonalLoanEntity> Post(GamePersonalLoanEntity GamePersonal);
        Task<GamePersonalLoanEntity> Put(GamePersonalLoanEntity GamePersonal);
        Task<bool> Delete(long id);   
    }
}