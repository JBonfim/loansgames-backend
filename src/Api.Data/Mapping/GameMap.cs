using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GameMap : IEntityTypeConfiguration<GameEntity>
    {
         public void Configure(EntityTypeBuilder<GameEntity> builder){
            builder.ToTable("Game");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descryption)
                .HasMaxLength(100);

            builder.Property(u => u.Details)
            .HasMaxLength(500);
        }

       
    }
}