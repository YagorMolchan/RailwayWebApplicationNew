using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;

namespace RailwayNew1.Repository.Interfaces
{
    public interface IWagonRepository
    {
        Task<List<Wagon>> GetWagonsByTrips(List<Trip> trips);
        Task<List<Wagon>> GetWagonsByRoutes(List<Route> routes);
    }
}
