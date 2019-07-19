using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.ViewModel.Search;
using RailwayNew1.Models.ViewModel.Trip;

namespace RailwayNew1.Repository.Interfaces
{
    public interface ITripRepository
    {
        Task<List<Trip>> GetTripsByRoutes(List<Route> routes);
        void SetIndexViewModelsByFromAndTo(List<Trip> trips, TicketViewModel model);
        void SetIndexViewModelsByTime(TicketViewModel model);
        void Create(Trip trip);
        void Save();
    }
}
