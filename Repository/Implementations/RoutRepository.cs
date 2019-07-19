using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.ViewModel.Route;
using RailwayNew1.Models.ViewModel.Search;
using RailwayNew1.Repository.Interfaces;
using RailwayNew1.Data;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Models.Domain.Entity;

namespace RailwayNew1.Repository.Implementations
{
    public class RoutRepository : IRoutRepository
    {
        private readonly RailwayContext _context;

        public RoutRepository(RailwayContext context)
        {
            _context = context;
        }

        public async Task<List<Models.ViewModel.Route.IndexViewModel>> GetRoutesForSchedule(Models.ViewModel.Search.IndexViewModel model)
        {
            List<Models.ViewModel.Route.IndexViewModel> listRoutes = new List<Models.ViewModel.Route.IndexViewModel>();
            var routes = await _context.Routes.Include(r => r.RouteStations).ThenInclude(rs => rs.Station).ToListAsync();

            foreach(var r in routes)
            {
                var items = r.RouteStations.Where(rs => rs.Station.Name == model.From).ToList();

                foreach (var item in items)
                {
                    var distance = item.Distance;
                    var routeItems = r.RouteStations.Where(rs => rs.Station.Name == model.To && rs.Distance > distance).ToList();
                    foreach (var ri in routeItems)
                    {
                        listRoutes.Add(
                            new Models.ViewModel.Route.IndexViewModel
                            {
                                Id = ri.Route.Id,
                                From = ri.Route.Start,
                                To = ri.Route.Finish,
                                Arrival = ri.Arrival,
                                ParkingTime = ri.ParkingTime,
                                Departure = ri.Departure
                            }
                        );
                    }
                }
            }
            return listRoutes.OrderBy(r => r.Departure).ToList<Models.ViewModel.Route.IndexViewModel>();
        }
              
        public async Task<List<Route>> GetRoutesForSchedule(TicketViewModel model)
        {
            List<Route> listRoutes = new List<Route>();
            var routes = await _context.Routes.Include(r => r.RouteStations).ThenInclude(rs => rs.Station).ToListAsync();

            foreach (var r in routes)
            {
                var items = r.RouteStations.Where(rs => rs.Station.Name == model.From).ToList();

                foreach (var item in items)
                {
                    var distance = item.Distance;
                    var routeItems = r.RouteStations.Where(rs => rs.Station.Name == model.To && rs.Distance > distance).ToList();
                    foreach (var ri in routeItems)
                    {
                        listRoutes.Add(
                            ri.Route
                        );
                    }
                }
            }
            return listRoutes;
        }
    }
}
