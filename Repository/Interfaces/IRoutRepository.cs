using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.ViewModel.Route;
using RailwayNew1.Models.ViewModel.Search;
using RailwayNew1.Models.Domain.Entity;

namespace RailwayNew1.Repository.Interfaces
{
    public interface IRoutRepository
    {
        Task<List<Models.ViewModel.Route.IndexViewModel>> GetRoutesForSchedule(Models.ViewModel.Search.IndexViewModel model);
        Task<List<Route>> GetRoutesForSchedule(Models.ViewModel.Search.TicketViewModel model);
    }
}
