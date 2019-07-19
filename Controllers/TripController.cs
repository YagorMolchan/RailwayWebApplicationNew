using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RailwayNew1.Models.ViewModel.Search;
using RailwayNew1.Models.ViewModel.Trip;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.Domain.ManyToMany;
using RailwayNew1.Data;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Repository.Implementations;

namespace RailwayNew1.Controllers
{
    public class TripController : Controller
    {
        private readonly RailwayContext _context;
        private readonly RoutRepository _routRepository;        

        public TripController(RailwayContext context)
        {
            _context = context;
        }

        // GET: Trip
        public async Task<ActionResult> Index(TicketViewModel model)
        {
            List<Route> routes = await _routRepository.GetRoutesForSchedule(model);


            return View();
        }

        private void SetList(List<RouteStation> routeStations, TicketViewModel model)
        {
            foreach(var routeStation in routeStations)
            {
                var trip = context.Trips.FirstOrDefault(t => t.Date == model.Date && t.Route == routeStation.Route);
                if(trip==null)
                {
                    var wagonRoutes = context.Routes.Include(rt => rt.WagonRoutes).ThenInclude(wr => wr.Wagon).ToList();
                    //foreach(var wagonRoute in wagonRoutes)
                    //{
                    //    from wr in wagonRoute.WagonRoutes
                    //    join w in context.Wagons on wr.Wagon.Id equals w.
                    //}
                }
            }
        }




        // GET: Trip/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trip/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Trip/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trip/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Trip/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trip/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}