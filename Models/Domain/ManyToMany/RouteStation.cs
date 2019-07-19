using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayNew1.Models.Domain.ManyToMany
{
    public class RouteStation
    {
        public int Id { get; set; }

        //public int RouteId { get; set; }
        //[ForeignKey("RouteId")]
        public Route Route { get; set; }

        //public int StationId { get; set; }
        //[ForeignKey("StationId")]
        public Station Station { get; set; }

        public TimeSpan? Arrival { get; set; }
        public TimeSpan? ParkingTime { get; set; }
        public TimeSpan? Departure { get; set; }
        public float? Distance { get; set; }

    }
}
