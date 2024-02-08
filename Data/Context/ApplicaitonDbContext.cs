using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Configurations;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Data.Context
{
    public class ApplicaitonDbContext: DbContext
    {
        


        //public ApplicaitonDbContext()
        //{


        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source =.;Initial Catalog = Transport2 ;Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configurations
            new DriversTypeConfigurations().Configure(modelBuilder.Entity<Driver>());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicaitonDbContext).Assembly);
        }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<ScheduleMaintence> ScheduleMaintences { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}
