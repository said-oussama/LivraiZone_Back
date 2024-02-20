using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Configurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            // Configuration pour le type decimal sur la colonne RentalCost
            builder.Property(P => P.TotalCost)
                .HasColumnType("decimal(18,2)");
        }
    }
}
