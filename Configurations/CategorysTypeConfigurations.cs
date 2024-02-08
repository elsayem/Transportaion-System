using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public class CategorysTypeConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            //Relations 
            // 1 (Category) - M (Vehicles)
            builder.HasMany(v => v.Vehicles)
                .WithOne(c => c.Category)
                .HasForeignKey(v => v.CategoryId);


            //Index
            builder.HasIndex(i => i.Name);


            //PK
            builder.HasKey(c => c.Id);

            //Constrains
            builder.Property(c => c.Name).HasMaxLength(20).IsRequired();
            builder.Property(c => c.NumberOfSeats).IsRequired();



        }
    }
}

