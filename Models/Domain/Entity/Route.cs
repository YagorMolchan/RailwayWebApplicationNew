using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.ManyToMany;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Route
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }

        //public int TrainId { get; set; }        
        //public Train Train { get; set; }

        //public int TripId { get; set; }
        public ICollection<Trip> Trips { get; set; }

        public ICollection<RouteStation> RouteStations { get; set; }
        public ICollection<WagonRoute> WagonRoutes { get; set; }

        public Route()
        {
            Trips = new List<Trip>();
            RouteStations = new List<RouteStation>();
            WagonRoutes = new List<WagonRoute>();
        }
    }
}
