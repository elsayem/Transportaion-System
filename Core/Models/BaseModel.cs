using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Constants;

namespace TransportReservationSystem.Core.Models
{
    public class BaseModel
    {
       
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$")]
        public string Email { get; set; } = null!;

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$")]
        public string Password { get; set; } = null!;
        public string Role { get; set;} = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public bool IsDeleted { get; set; } = false;

    }
}
