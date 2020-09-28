
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Api.Data.context
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
         public IConfiguration Configuration { get; }
        public ContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       
        public Context CreateDbContext(string[] args)
        {
            var host =  Configuration["DBHOST"] ?? "localhost";
            var port =  Configuration["DBPORT"] ?? "3306";
            var password =  Configuration["DBPASSWORD"] ?? "root";
            var connectionString = $"server={host};userid=root; pwd={password}; port={port};database=dbAPI";
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseMySql(connectionString);
            return new Context(optionsBuilder.Options);
        }
    }
}