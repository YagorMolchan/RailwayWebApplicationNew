using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RailwayNew1.Models.Domain.Entity;


namespace RailwayNew1.Models.ViewModel.Trip
{
    public class IndexViewModel
    {
        [Display(Name ="Номер маршрута")]
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        [UIHint("HiddenInput")]
        public RailwayNew1.Models.Domain.Entity.Route Route { get; set; }
        [Display(Name ="Прибытие")]
        public TimeSpan? Arrival { get; set; }
        [Display(Name ="Стоянка")]
        public TimeSpan? ParkingTime { get; set; }
        [Display(Name ="Отправление")]
        public TimeSpan? Departure { get; set; }
        public int? CompartmentCount { get; set; }
        public float? CompartmentPrice { get; set; }
        public int? EconomClassCount { get; set; }
        public float? EconomPrice { get; set; }
        public int? GeneralCount { get; set; }
        public float? GeneralPrice { get; set; }
        public int? SeatCount { get; set; }
        public float? SeatPrice { get; set; }
        public int? SleepingCount { get; set; }
        public float? SleepingPrice { get; set; }
        public int? LuxuryCount { get; set; }
        public float? LuxuryPrice { get; set; }

    }
}
