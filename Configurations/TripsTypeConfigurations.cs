using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class TripsTypeConfigurations : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {

            //Relations 
            // 1 (trip) - M (Reservations)             
            builder.HasMany(x => x.Reservations)
                .WithOne(x => x.Trip)
                .HasForeignKey(x => x.TripId)
                .IsRequired(false);


            //Index
            builder.HasIndex(t => t.TripNo);
            builder.HasIndex(t => t.DepatureDate);
            builder.HasIndex(t => t.Destination);

            //PK
            builder.HasKey(t => t.Id);


            //Constrains
            builder.Property(t => t.TripNo).IsRequired();
            builder.Property(t => t.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.UpdatedAt).HasColumnType("date");
            //The Other constraints Implemnted in the Trip Model 



        }
    }
}
