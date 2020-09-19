using System.Threading.Tasks;
using Api.Data.context;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
         private DbSet<UserEntity> _dataset;

        public UserRepository(Context context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }

       
        public async Task<UserEntity> FindByLogin(string login,string password)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Login.Equals(login) &&
            u.Password.Equals(password));
        }

       
    }
}