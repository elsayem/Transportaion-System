using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    
        public partial class MaintenancesTypeConfigurations : IEntityTypeConfiguration<Maintenance>
        {
            public void Configure(EntityTypeBuilder<Maintenance> builder)
            {

                //Relations 
                // 1 (driver) - M (Maintenances) --> Done in the Drivers  Configurations



                //Index
                builder.HasIndex(i => i.CreatedAt);
                builder.HasIndex(i => i.DriverId);


                //PK
                builder.HasKey(i => i.Id);


                //Constrains
                builder.Property(p => p.CreatedAt).IsRequired();
                builder.Property(p => p.CostOfMaintenece).IsRequired();
                //builder.Property(p=>p.Vehicle).IsRequired();






            }
        }
    }


