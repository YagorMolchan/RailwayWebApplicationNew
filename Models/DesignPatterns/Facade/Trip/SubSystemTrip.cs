using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Repository.Implementations;

namespace RailwayNew1.Models.DesignPatterns.Facade.Trip
{
    public class SubSystemTrip
    {
        public async Task<List<RailwayNew1.Models.Domain.Entity.Trip>> GetTrips(TripRepository repository, List<Route> routes)
        {
            return await repository.GetTripsByRoutes(routes);
        }
    }
}
