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

    public class ApplicaitonDbContext : DbContext
    {

        //DB Sets
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<ScheduleMaintence> ScheduleMaintences { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Trip> Trips { get; set; }

        //public ApplicaitonDbContext()
        //{


        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseLazyLoadingProxies()
        //        .UseSqlServer("Data Source =.;Initial Catalog = Transport2 ;Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False");



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=Administrator;Database=Transport;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            //Configurations
            //new DriversTypeConfigurations().Configure(modelBuilder.Entity<Driver>());
            //Use this Line to Apply All Configrations at Once 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicaitonDbContext).Assembly);
        }

       



    }
}
