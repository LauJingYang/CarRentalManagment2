using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagment2.Configurations.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagment2.Data
{
    public class CarRentalManagment2Context : DbContext
    {
        public CarRentalManagment2Context (DbContextOptions<CarRentalManagment2Context> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement2.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
