using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Repository.Implementations;
using RailwayNew1.Repository.Interfaces;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Data;
using Microsoft.EntityFrameworkCore;

namespace RailwayNew1.Repository.Implementations
{
    public class WagonRepository:IWagonRepository
    {
        private readonly RailwayContext _context;

        public WagonRepository(RailwayContext context)
        {
            _context = context;
        }

        public async Task<List<Wagon>> GetWagonsByTrips(List<Trip> trips)
        {
            var trips = await trips.Include(t => t.Route).ToListAsync();

        }
    }
}
