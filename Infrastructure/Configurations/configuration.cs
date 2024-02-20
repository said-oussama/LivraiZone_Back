﻿//using Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.Configurations
//{
//    public class configuration : DbContext
//    {
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Add other configurations as needed...

//            //one to many (Member and Rentals)
//            modelBuilder.Entity<Member>()
//                .HasOne<Rental>(s => s.Rental)
//                .WithMany(r => r.Members)
//                .HasForeignKey(s => s.RentalId);

//            //Many to many (rental and movie )
//            modelBuilder.Entity<MovieRental>()
//                .HasKey(g => new { g.RentalId, g.MovieId });

//            //handle decimals to avoid precision loss
//            modelBuilder.Entity<Rental>()
//              .Property(P => P.TotalCost)
//              .HasColumnType("decimal(18,2)");

//            //handle decimals to avoid precision loss
//            modelBuilder.Entity<Movie>()
//              .Property(P => P.RentalCost)
//              .HasColumnType("decimal(18,2)");
//        }
//    }

//}
