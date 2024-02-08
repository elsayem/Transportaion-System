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

        [Required]
        public DateTime DepatureDate {  get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public int SourceId { get; set; }
        public virtual Station Source { get; set; } = null!;
        [Required]
        public int DestinationId { get; set; }
        public Station Destination { get; set; } = null!;

        [Required]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;

        [Required]
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; } = null!;

        [Required]
        public decimal Fare { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        //Collection of Reservations in the Same trip
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
