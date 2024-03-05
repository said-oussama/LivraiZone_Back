using LivraiZone.Domain.Entities;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.OpenApi.Models;
using LivraiZone.Infrastructure.Repository;
using LivraiZone.Application.Interfaces;

namespace LivraiZone.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddDbContext<AppDbContext>(options =>
            //     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<AppUser, IdentityRole>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddDefaultTokenProviders();

            //// Ajoutez ici d'autres services nécessaires à votre application

            //services.AddSwaggerGen(options =>
            //{
            //    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            //    {
            //        In = ParameterLocation.Header,
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.ApiKey
            //    });

            //    options.OperationFilter<SecurityRequirementsOperationFilter>();
            //});
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddSqlServer<AppDbContext>(
            //    configuration.GetConnectionString("DefaultConnection"), null); services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("LivraiZone.API")));
            services.AddSqlServer<AppDbContext>(
                configuration.GetConnectionString("DefaultConnection"), null);

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("LivraiZone.API")));

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            


            return services;

        }



    }
}
