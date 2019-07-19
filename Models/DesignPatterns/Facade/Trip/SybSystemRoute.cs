using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Repository.Implementations;
using RailwayNew1.Models.ViewModel.Search;

namespace RailwayNew1.Models.DesignPatterns.Facade.Trip
{
    public class SybSystemRoute
    {
        public Task<List<Route>> GetRoutes(RoutRepository repository, TicketViewModel model)
        {
            return repository.GetRoutesForSchedule(model);
        }
    }
}
