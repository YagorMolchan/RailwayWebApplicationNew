using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Online
{
    public class IndexViewModel
    {
        [Required(ErrorMessage ="Укажите название станции")]
        public string Station { get; set; }
    }
}
