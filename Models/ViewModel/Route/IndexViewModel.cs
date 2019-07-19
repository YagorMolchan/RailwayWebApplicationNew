using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Route
{
    public class IndexViewModel
    {  
        public int Id { get; set; }
        public string From { get; set; }        
        public string To { get; set; }
        [Display(Name ="Прибытие")]
        public TimeSpan? Arrival { get; set; }
        [Display(Name ="Стоянка")]
        public TimeSpan? ParkingTime { get; set; }
        [Display(Name ="Отправление")]
        public TimeSpan? Departure { get; set; }
    }
}
