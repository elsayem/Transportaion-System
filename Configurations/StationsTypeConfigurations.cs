using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class StationsTypeConfigurations : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {

            //Relations 
            // one (trip) to many (staions)
            


            //Index
            builder.HasIndex(t => t.Name);
            

            //PK
            builder.HasKey(t => t.Id);


            //Constrains
            builder.Property(t => t.Name).HasColumnType("VARCHAR").IsRequired();
            builder.Property(t => t.CreatedAt).HasColumnType("date").IsRequired();
            builder.Property(t => t.UpdatedAt).HasColumnType("date").IsRequired();

        }
    }
    
}
