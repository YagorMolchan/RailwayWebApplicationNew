using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayNew1.Models.Domain.Entity

{
    public class User
    {
        public int Id { get; set; }
        public string Surename { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }     
        
        public ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}
