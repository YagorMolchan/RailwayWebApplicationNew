using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        //public int RouteId { get; set; }
        public Route Route { get; set; }

        public int? CompartmentCount { get; set; }//Купе
        public int? EconomClassCount { get; set; }//Плацкатный
        public int? SeatCount { get; set; }// Сидячий, 
        public int? GeneralCount { get; set; }
        public int? SleepingCount { get; set; }// СВ
        public int? LuxuryCount { get; set; }// Люкс

        public ICollection<Ticket> Tickets { get; set; }

        public Trip()
        {
            Tickets = new List<Ticket>();
        }

    }
}
