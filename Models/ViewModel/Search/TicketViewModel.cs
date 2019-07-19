using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Search
{
    public class TicketViewModel
    {
        [Required(ErrorMessage = "Укажите пункт отправления")]
        public string From { get; set; }
        [Required(ErrorMessage = "Укажите пункт прибытия")]
        public string To { get; set; }
        [Required(ErrorMessage = "Укажите дату поездки")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage ="Укажите время поездки")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString ="{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [Range(typeof(TimeSpan),"00:00","23:59")]
        public TimeSpan Time { get; set; }
    }
}
