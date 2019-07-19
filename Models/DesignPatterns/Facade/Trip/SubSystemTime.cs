using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Repository.Implementations;
using RailwayNew1.Models.ViewModel.Search;

namespace RailwayNew1.Models.DesignPatterns.Facade.Trip
{
    public class SubSystemTime
    {
        public void SetTime(TripRepository repository, TicketViewModel model)
        {
            repository.SetIndexViewModelsByTime(model);
        }
    }
}
