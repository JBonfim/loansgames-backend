using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.GamePersonalLoan;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.GamePersonalLoan
{
    public interface IGamePersonalLoanService
    {
        Task<GamePersonResponseView> Get(long id);
        Task<IEnumerable<GamePersonResponseView>> GetAll();
        Task<GamePersonResponseView> Post(GamePersonLoanCreateDomainModel GamePersonal);
        Task<GamePersonResponseView> Put(GamePersonLoanUpdateDomainModel GamePersonal);
        Task<bool> Delete(long id);   
    }
}