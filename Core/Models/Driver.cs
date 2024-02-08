using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Driver : BaseModel
    {
        public int Id { get; set; }
        public decimal License { get; set; }
        public string Name { get; set; } = null!;

        [RegularExpression(@"^\d{11}$", ErrorMessage = "Mobile phone must be 11 Numbers")]
        public string Phone { get; set; } = null!;
        public bool HasBouns { get; set; } = false;
        public decimal Salary { get; set; }
        
        public string Station { get; set; } = null!; //

        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();
    }
}
