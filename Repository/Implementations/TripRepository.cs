using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Data;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.ViewModel.Trip;
using RailwayNew1.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Models.ViewModel.Search;

namespace RailwayNew1.Repository.Implementations
{
    public class TripRepository : ITripRepository
    {
        private readonly RailwayContext _context;      

        public List<Models.ViewModel.Trip.IndexViewModel> viewModels { get; set; }

        public TripRepository(RailwayContext context)
        {
            _context = context;
            viewModels = new List<Models.ViewModel.Trip.IndexViewModel>();
        }

        public async Task<List<Trip>> GetTripsByRoutes(List<Route> routes)
        {
            List<Trip> listTrips = new List<Trip>();
            foreach (var r in routes)
            {
                var trips = _context.Trips.Where(t => t.Route == r).ToList<Trip>();
                listTrips.AddRange(trips);
            }
            return listTrips;
        }
        
        public void SetIndexViewModelsByFromAndTo(List<Trip> trips, TicketViewModel model)
        {
            foreach(Trip t in trips)
            {
                viewModels.Add(
                    new Models.ViewModel.Trip.IndexViewModel
                    {
                        Id = t.Id,
                        From = t.Route.Start,
                        To = t.Route.Finish,
                        Route = t.Route
                    }
                );
            }            
        }

        public void SetIndexViewModelsByTime(TicketViewModel model)
        {

            foreach(var viewModel in viewModels)
            {
                var items = viewModel.Route.RouteStations.Where(rs => rs.Station.Name == model.From).ToList();
                foreach(var item in items)
                {
                    var distance = item.Distance;
                    var routeItems = viewModel.Route.RouteStations.Where(rs => rs.Station.Name == model.To && rs.Distance > distance).ToList();
                    foreach(var ri in routeItems)
                    {
                        viewModel.Arrival = ri.Arrival;
                        viewModel.ParkingTime = ri.ParkingTime;
                        viewModel.Departure = ri.Departure;
                    }
                }
            }            
        }

        public void Create(Trip trip)
        {
            _context.Trips.Add(trip);
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

    }
}
