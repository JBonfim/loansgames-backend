using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PersonMap: IEntityTypeConfiguration<PersonEntity>
    {
         public void Configure(EntityTypeBuilder<PersonEntity> builder){
            builder.ToTable("Person");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .HasMaxLength(100);

            builder.Property(u => u.phone)
            .HasMaxLength(100);

            builder.Property(u => u.Address)
            .HasMaxLength(500);


        }
        
    }
}