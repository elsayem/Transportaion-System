using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Passenger:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [RegularExpression(@"^\d{11}$", ErrorMessage = "Mobile phone must be 11 Numbers")]
        public string Phone {  get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
