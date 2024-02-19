using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Member> Member { get; set; }
        public DbSet<Movie> Movies { get; set; }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add other configurations as needed...

            base.OnModelCreating(modelBuilder);

        }




    }
}
