using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class PassengersTypeConfigurations : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {

            //Relations 

            //Basic many-to-many
            // M (Reservation) - M (Passengers)   --> Done in the Reservations Configurations        
            //builder.HasMany(p => p.Reservations)
            //    .WithMany(r => r.Passengers);


            //Index
            builder.HasIndex(i => i.Name);
            builder.HasIndex(i => i.Address);

            //PK
            builder.HasKey(p => p.Id);


            //Constrains
            builder.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Address).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
        }

    }
}
