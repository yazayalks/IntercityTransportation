using IntercityTransportation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntercityTransportation.DataBase
{
    public class IntercityTransportationDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BusStop> BusStops { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Driver> Drivers { get; set; } 
        public DbSet<DriverCategory> DriverCategories { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("db");
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=IntercityTransportation;Username=postgres;Password=6969");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .HasMany(x => x.BusStops)
                .WithMany(x => x.Routes)
                .UsingEntity(j => j.ToTable("WayPoints"));

            modelBuilder.Entity<Route>()
                .HasOne(x => x.StartingPoint)
                .WithMany();

            modelBuilder.Entity<Route>()
               .HasOne(x => x.EndingPoint)
               .WithMany();

            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveConversion<UtcValueConverter>();
            configurationBuilder.Properties<DateTime?>().HaveConversion<UtcValueConverter>();
            base.ConfigureConventions(configurationBuilder);
        }

        private class UtcValueConverter : ValueConverter<DateTime, DateTime>
        {
            public UtcValueConverter()
                : base(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc))
            {
            }
        }
    }

}
