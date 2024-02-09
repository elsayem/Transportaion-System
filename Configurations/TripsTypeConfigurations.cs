using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
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

            builder.HasOne(x => x.Source)
                .WithMany(x => x.SourceTrips)
                .HasForeignKey(x => x.SourceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Destination)
                .WithMany(x => x.DestinationTrips)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict) ;
 
            //builder.HasKey(x=> new {x.SourceId, x.DestinationId});
            //builder.HasOne(e => e.Source).WithOne(t => t.Trip).HasForeignKey<Trip>(k => k.TripId);
            //builder.HasOne(e => e.Destination).WithOne(t => t.Trip);

            //builder.HasOne(e => e.Destination).WithOne(t => t.Trip);

            //Index
            //builder.HasIndex(t => t.TripNo);
            //builder.HasIndex(t => t.DepatureDate);
            //builder.HasIndex(t => t.Destination);

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
