using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class DriversTypeConfigurations : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {

            //Relations 
            // 1 (driver) - M (Maintenances)             
            builder.HasMany(x => x.Maintenances)
                .WithOne(x => x.Driver)
                .HasForeignKey(x => x.DriverId)
                .IsRequired(false);

            // 1 (driver) - M (Trips)
            builder.HasMany(t => t.Trips)
                .WithOne(t => t.Driver)
                .HasForeignKey(t => t.DriverId);


            //Index
            builder.HasIndex(i => i.Name);
            builder.HasIndex(i => i.Email);
            builder.HasIndex(i => i.Station);            


            //PK
            builder.HasKey(d => d.Id);


            //Constrains
            builder.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Phone).HasColumnType("int").HasMaxLength(11).IsRequired();
            builder.Property(x => x.License).HasColumnType("int").HasMaxLength(14).IsRequired();
            builder.Property(x => x.Salary).IsRequired();
            builder.Property(x => x.Password).HasColumnType("VARCHAR").IsRequired();

        }
    }
}
