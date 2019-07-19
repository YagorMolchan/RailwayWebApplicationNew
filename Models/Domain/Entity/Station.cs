using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.ManyToMany;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Station
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }

        //public int DurationId { get; set; }        
        public Duration Duration { get; set; }

        public ICollection<RouteStation> RouteStations { get; set; }

        public Station()
        {
            RouteStations = new List<RouteStation>();
        }

    }
}
