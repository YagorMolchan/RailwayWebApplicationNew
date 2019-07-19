using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Data;
using RailwayNew1.Models.Domain.Specifications;
using Microsoft.EntityFrameworkCore;

namespace RailwayNew1.Models.DesignPatterns.Proxy.Wagon
{
    public class WagonStore : IWagon
    {
        RailwayContext _context;

        public WagonStore()
        {
            _context = new RailwayContext(new DbContextOptions<RailwayContext>());
        }

        public RailwayNew1.Models.Domain.Entity.Wagon GetWagon(int number)
        {
            return _context.Wagons.FirstOrDefault(w => w.Id==number);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
