using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Surename { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string TypeOfDocument { get; set; }
        public string NumberOfDocument { get; set; }

        //public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
