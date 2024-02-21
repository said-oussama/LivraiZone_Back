using Application.Interfaces;
using Application.Services;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddSqlServer<Context>(
                configuration.GetConnectionString("DefaultConnection"), null);
            //optionsBuilder => optionsBuilder.EnableSensitiveDataLogging(builder.Environment.IsDevelopment()));
            //Add Database service

            services.AddDbContext<Context>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Presentation")));

            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }
    }
}
