using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.context
{
    public class Context : DbContext
    {
          public DbSet<UserEntity> Users { get; set; }
           public DbSet<GameEntity> Games { get; set; }

            public DbSet<PersonEntity> Persons { get; set; }
            public DbSet<GamePersonalLoanEntity> GamePersonalLoans { get; set; }

          public Context(DbContextOptions<Context> options) :  base (options)
          {
              
          }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<UserEntity>(new UserMap().Configure);
                modelBuilder.Entity<GameEntity>(new GameMap().Configure);
                modelBuilder.Entity<PersonEntity>(new PersonMap().Configure);
                modelBuilder.Entity<GamePersonalLoanEntity>(new GamePersonalLoanMap().Configure);
            }


    }
}