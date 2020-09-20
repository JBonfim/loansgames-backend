using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repository
{
    public interface IGamePersonalLoanRepository : IRepository<GamePersonalLoanEntity>
    {
          Task<GamePersonalLoanEntity> FirstOrDefaultAsync(long  id);
          
          Task<IEnumerable<GamePersonalLoanEntity>> SelectAllAsync();

           Task<IEnumerable<GamePersonalLoanEntity>> SelectAllAsyncIsStatusIsActive();
    }   
}