using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayNew1.Models.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }

        //public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public Order()
        {
            Tickets = new List<Ticket>();
        }
    }
}
