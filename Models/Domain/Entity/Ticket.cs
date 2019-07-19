using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TypeOfTicket { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        //public int TripId { get; set; }
        public Trip Trip { get; set; }

        public Order Order { get; set; }

        public int SeatNumber { get; set; }
        public int WagonNumber { get; set; }
        
    }
}
