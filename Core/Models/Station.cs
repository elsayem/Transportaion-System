using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;



        public virtual ICollection<Trip> SourceTrips { get; set; } = new List<Trip>();
        public virtual ICollection<Trip> DestinationTrips { get; set; } = new List<Trip>();



        //Navigation properties
        //public int? TripId {  get; set; }
        //public virtual Trip? Trip { get; set; }
    }
}
