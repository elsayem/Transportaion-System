using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public decimal LicensePlate { get; set; }
        [Required]
        public string Model { get; set; } = null!; 
        [Required]
        public string Brand { get; set; } = null!; 
        [Required]
        public int Year {  get; set; }
        [Required]
        public string Color { get; set; } = null!; 
        [Required]
        public int Code { get; set; }
        
        public bool IsAvailable { get; set; } = true;
        [Required]
        public int AvailableSeats { get; set; }

        public bool HasMaintenance { get; set; } = false;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public ICollection<ScheduleMaintence> ScheduleMaintences { get; set; } = new List<ScheduleMaintence>();

        [Required]
        public bool HasScheduledMaintenance { get; set; } = false;


        [Required]
        public string Station { get; set; } = null!;
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
