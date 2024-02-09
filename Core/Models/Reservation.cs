using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Reservation
    {
        public int Id { get; set; }       

        public Trip Trip { get; set; } = null!;
        public int TripId { get; set; }
        public List<string> Seats { get; set; } = new List<string>();
        public decimal TotalCost {  get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();



        //public int PassengerId { get; set; }
        //public Passenger Passenger { get; set; } = null!; 
    }
}
