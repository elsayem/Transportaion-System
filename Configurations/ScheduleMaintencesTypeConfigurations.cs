using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class ScheduleMaintencesTypeConfigurations : IEntityTypeConfiguration<ScheduleMaintence>
    {
        public void Configure(EntityTypeBuilder<ScheduleMaintence> builder)
        {

            //Relations 
            // 1 (vehicle) - M (ScheduleMaintence)        --> Done in the Vehicle Configrations     
            


            //Index
            builder.HasIndex(t => t.VehicleId);
            builder.HasIndex(t => t.CreatedAt);
            builder.HasIndex(t => t.IsMainteneceDone);

            //PK
            builder.HasKey(t => t.Id);


            //Constrains
            builder.Property(t => t.MainteneceDateStart).HasColumnType("date").IsRequired();
            builder.Property(t => t.MainteneceDateEnd).HasColumnType("date").IsRequired();



        }
    }
    
}
