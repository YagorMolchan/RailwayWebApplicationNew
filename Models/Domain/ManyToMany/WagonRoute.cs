using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayNew1.Models.Domain.ManyToMany
{
    public class WagonRoute
    {
        public int Id { get; set; }

        //public int RouteId { get; set; }
        //[ForeignKey("RouteId")]
        public Route Route { get; set; }
        //public int WagonId { get; set; }
        //[ForeignKey("WagonId")]
        public Wagon Wagon { get; set; }

    }
}
