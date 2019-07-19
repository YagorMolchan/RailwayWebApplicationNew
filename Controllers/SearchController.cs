using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RailwayNew1.Data;
using RailwayNew1.Models.ViewModel.Search;
using RailwayNew1.Models.ViewModel.Route;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Models.Domain.Entity;


namespace RailwayNew1.Controllers
{
    public class SearchController : Controller
    {
        private RailwayContext context;

        public SearchController(RailwayContext context_)
        {
            context = context_;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RailwayNew1.Models.ViewModel.Search.IndexViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                var stationFrom = context.Stations.FirstOrDefault(s => s.Name == model.From);
                var stationTo = context.Stations.FirstOrDefault(s => s.Name == model.To);
                              

                return RedirectToAction("Index", "Routes", model);
            }            
            else
            {
               ModelState.AddModelError("", "Ошибка валидации");
            }

            return View(model);
            
        }

        [HttpGet]
        public IActionResult TicketIndex()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TicketIndex(TicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                var stationFrom = context.Stations.FirstOrDefault(s => s.Name == model.From);
                var stationTo = context.Stations.FirstOrDefault(s => s.Name == model.To);

                //    List<Models.ViewModel.Route.IndexViewModel> viewModels = new List<Models.ViewModel.Route.IndexViewModel>();
                //    var routes = context.Routes.AsEnumerable<Route>();
                //    //viewModels.AddRange(routes);
                //    foreach (var r in routes)
                //    {

                //        viewModels.Add(new Models.ViewModel.Route.IndexViewModel
                //        {
                //            Id = r.Id,
                //            Start = r.Start,
                //            Finish = r.Finish,

                //        });
                //    }

                //    return RedirectToAction("Index", "Route", viewModels);
            }
            else
            {
                ModelState.AddModelError("", "Ошибка валидации");
            }

            return View(model);
        }

        


    }
}