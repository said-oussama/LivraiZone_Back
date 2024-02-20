using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }

        public Context()
        {

        }

        public Context(DbContextOptions <Context> options) : base (options) 
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Add other configurations as needed...

        //    base.OnModelCreating(modelBuilder);

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new Configuration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new RentalConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new MovieRentalConfiguration());
        }




    }
}
