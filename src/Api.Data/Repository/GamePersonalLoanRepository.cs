using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.context;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class GamePersonalLoanRepository : BaseRepository<GamePersonalLoanEntity>, IGamePersonalLoanRepository
    {
        private DbSet<GamePersonalLoanEntity> _dataset;
        public GamePersonalLoanRepository(Context context) : base(context)
        {
             _dataset = context.Set<GamePersonalLoanEntity>();
        }

        public async Task<GamePersonalLoanEntity> FirstOrDefaultAsync(long id)
        {
             IQueryable<GamePersonalLoanEntity> query = _dataset
                .Include(p => p.Person)
                .Include(g => g.Game);

                query = query.Where(c => c.Id  ==  id);

             return await query.FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<GamePersonalLoanEntity>> SelectAllAsync()
        {
              IQueryable<GamePersonalLoanEntity> query = _dataset
                .Include(p => p.Person)
                .Include(g => g.Game);
           return await query.ToListAsync();
        }
    }
}