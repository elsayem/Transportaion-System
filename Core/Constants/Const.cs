using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Constants
{
    public class Const
    {
    }

    public enum Role
    {
        DRIVER = 1,
        PASSENGER = 2,
        ADMIN = 3,
        STAFF = 4 
    }

    public enum Reservation
    {
        ONGOING = 1,
        CANCELATION = 2,

    }
}
