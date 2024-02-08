using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class ReservationsTypeConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {

            //Relations 
            //Basic many-to-many
            // M (Reservation) - M (Passengers)             
            builder.HasMany(p => p.Passengers)
                .WithMany(r => r.Reservations);          


            //Index
            builder.HasIndex(i => i.PassengerId);
            builder.HasIndex(i => i.TotalCost);
            builder.HasIndex(i => i.Seats);

            //PK
            builder.HasKey(d => d.Id);


            //Constrains
            builder.Property(x => x.Seats).IsRequired();
            builder.Property(x => x.TotalCost).IsRequired();
            builder.Property(x => x.Seats).IsRequired();
        }

    }
    
}
