using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GamePersonalLoanMap: IEntityTypeConfiguration<GamePersonalLoanEntity>
    {
       
         public void Configure(EntityTypeBuilder<GamePersonalLoanEntity> builder){
            builder.ToTable("GamePersonalLoan");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.IdGame)
                .IsRequired(); 

            builder.Property(u => u.IdPerson)
            .IsRequired(); 

              builder.Property(u => u.isActive);

            builder.HasOne(x => x.Game)
                .WithMany(x => x.Gamepersonalloan)
                .HasForeignKey(x => x.IdGame)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction   );


            builder.HasOne(x => x.Person)
                .WithMany(x => x.Gamepersonalloan)
                .HasForeignKey(x => x.IdPerson)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}