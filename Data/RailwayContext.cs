using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.Domain.ManyToMany;

namespace RailwayNew1.Data
{
    public class RailwayContext:DbContext
    {
        public DbSet<Duration> Durations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
        //public DbSet<Train> Trains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }

        public RailwayContext(DbContextOptions<RailwayContext> options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            //builder.Entity<Route>().HasData(
            //    new Route[]
            //    {
            //        new Route {Start ="Минск-Пассажирский", Finish="Москва-Белорусская", Country="Беларусь", Category="Скорый фирменный поезд"},
            //        new Route {Start = "Москва-Белорусская", Finish="Минск-Пассажирский", Country="Беларусь", Category="Скорый фирменный поезд"}
            //    }
            //);
            base.OnModelCreating(builder);
            //Duration - Station (1:m)
            //builder.Entity<Duration>()
            //    .HasMany(d => d.Stations)
            //    .WithOne(s => s.Duration);

            ////Station - Route (m:m)
            ////builder.Entity<RouteStation>()
            ////    .HasKey(rs => new { rs.RouteId, rs.StationId });
            //builder.Entity<RouteStation>()
            //    .HasOne(rs => rs.Route)
            //    .WithMany(r => r.RouteStations);
            ////.HasForeignKey(r => r.RouteId);
            //builder.Entity<RouteStation>()
            //    .HasOne(rs => rs.Station)
            //    .WithMany(s => s.RouteStations);
            //// .HasForeignKey(s => s.Route);

            //////Trin - Route (1:1)
            ////builder.Entity<Train>()
            ////    .HasOne(t => t.Route)
            ////    .WithOne(r => r.Train)
            ////    .HasForeignKey<Route>(t => t.TrainId);

            ////Train - Wagon (m:m)
            ////builder.Entity<WagonRoute>()
            ////   .HasKey(wt => new { wt.RouteId, wt.WagonId });
            //builder.Entity<WagonRoute>()
            //    .HasOne(wt => wt.Route)
            //    .WithMany(w => w.WagonRoutes);
            ////.HasForeignKey(w => w.RouteId);
            //builder.Entity<WagonRoute>()
            //    .HasOne(wt => wt.Route)
            //    .WithMany(w => w.WagonRoutes);
            ////.HasForeignKey(w => w.RouteId);

            ////Route - Trip (1:1)
            //builder.Entity<Route>()
            //    .HasOne(r => r.Trip)
            //    .WithOne(tr => tr.Route)
            //    .HasForeignKey<Trip>(t => t.RouteId);

            ////Passenger - Ticket(1:1)
            //builder.Entity<Passenger>()
            //    .HasOne(p => p.Ticket)
            //    .WithOne(t => t.Passenger)
            //    .HasForeignKey<Ticket>(t => t.PassengerId);

            ////Trip - Ticket (1:m)
            //builder.Entity<Trip>()
            //    .HasMany(tr => tr.Tickets)
            //    .WithOne(t => t.Trip);

            ////Order - Ticket(1:m)
            //builder.Entity<Order>()
            //    .HasMany(o => o.Tickets)
            //    .WithOne(t => t.Order);

            ////Order - User (m:1)
            //builder.Entity<Order>()
            //    .HasOne(o => o.User)
            //    .WithMany(u => u.Orders);




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=desktop-u2onrpk\sqlexpress;Trusted_Connection=True;Initial Catalog=RailwayDb1;User ID=#;Password=#;Trusted_Connection=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        public DbSet<RailwayNew1.Models.Domain.ManyToMany.RouteStation> RouteStation { get; set; }
    }
}
