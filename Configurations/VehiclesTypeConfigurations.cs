using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class VehiclesTypeConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {

            //Relations 
            //One(vehicle) to Many(Schaduled Maintinance)
            builder.HasMany(m => m.ScheduleMaintences)
                .WithOne(m => m.Vehicle)
                .HasForeignKey(f => f.VehicleId);

            //Index
            builder.HasIndex(i => i.Model);
            builder.HasIndex(i => i.CategoryId);

            //PK
            builder.HasKey(d => d.Id);


            //Constrains            
            builder.Property(x => x.LicensePlate).HasMaxLength(8).IsRequired();
            builder.Property(x => x.Year).HasMaxLength(4).IsRequired();
            builder.Property(x => x.Model).IsRequired();

        }

    }

}
