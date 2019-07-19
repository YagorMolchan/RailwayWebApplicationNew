using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.ManyToMany;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Wagon
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SeatCount { get; set; }
        public float Price { get; set; }

        public ICollection<WagonRoute> WagonTrains { get; set; }

        public Wagon()
        {
            WagonTrains = new List<WagonRoute>();
        }
    }
}
