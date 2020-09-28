using Api.Data.context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IGamePersonalLoanRepository, GamePersonalLoanRepository>();


            serviceCollection.AddDbContext<Context>(
                options => options.UseMySql("Server=mysql8;Port=3306;DataBase=dbAPI;Uid=root;Pwd=root")
            );
        }
        
    }
}