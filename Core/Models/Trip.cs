using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Trip
    {
        public int Id {  get; set; }
        public int TripNo {  get; set; }

        public DateTime DepatureDate {  get; set; }

        public DateTime ArrivalDate { get; set; }


        //Stations
        public int? SourceId { get; set; }
        public virtual Station? Source { get; set; } = null!;
        public int? DestinationId { get; set; }
        public virtual Station? Destination { get; set; } = null!;

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;

        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; } = null!;

        public decimal Fare { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        //Collection of Reservations in the Same trip
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
