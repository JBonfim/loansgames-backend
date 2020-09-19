using Api.Domain.Interfaces.Services.Game;
using Api.Domain.Interfaces.Services.GamePersonalLoan;
using Api.Domain.Interfaces.Services.Person;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
         public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IGameService, GameService>();
            serviceCollection.AddTransient<IPersonService, PersonService>();
            serviceCollection.AddTransient<IGamePersonalLoanService, GamePersonalLoanService>();
        }
        
    }
}