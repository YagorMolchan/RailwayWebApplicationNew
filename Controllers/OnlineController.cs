using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RailwayNew1.Models.ViewModel.Online;
using RailwayNew1.Data;
using Microsoft.EntityFrameworkCore;


namespace RailwayNew1.Controllers
{
    public class OnlineController : Controller
    {

        private RailwayContext context;

        public OnlineController(RailwayContext _context)
        {
            context = _context;
        }


        public async Task<IActionResult> Index()
        {
            List<RailwayNew1.Models.ViewModel.Route.IndexViewModel> models = new List<RailwayNew1.Models.ViewModel.Route.IndexViewModel>();
            var station = context.Stations.FirstOrDefault(s => s.Name == "Минск-Пассажирский");
            if(station!=null)
            {
                var routes = await context.Routes.Include(r => r.RouteStations).ThenInclude(rs => rs.Station).ToListAsync();
                foreach(var r in routes)
                {
                    var items = r.RouteStations.Where(rs => rs.Station == station /*&& rs.Arrival >= DateTime.Now.TimeOfDay || rs.Departure >= DateTime.Now.TimeOfDay*/).ToList();
                    foreach(var item in items)
                    {
                        models.Add(new Models.ViewModel.Route.IndexViewModel
                        {
                            Id = item.Route.Id,
                            From = item.Route.Start,
                            To = item.Route.Finish,
                            Arrival = item.Arrival,
                            ParkingTime = item.ParkingTime,
                            Departure = item.Departure
                        });
                    }

                    for(int i = 0; i < models.Count; i++)
                    {
                        if(models[i].Arrival <= DateTime.Now.TimeOfDay || models[i].Departure <= DateTime.Now.TimeOfDay)
                        {
                            models.Remove(models[i]);
                        }
                    }

                    
                }
            }

            return View(models.OrderBy(m => m.Departure).OrderBy(m => m.Arrival));
        }
    }
}