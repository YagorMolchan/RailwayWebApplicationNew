using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Duration
    {        
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<Station> Stations { get; set; }

        public Duration()
        {
            Stations = new List<Station>();
        }
    }
}
