using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            // Configuration pour le type decimal sur la colonne RentalCost
            builder.Property(P => P.RentalCost)
                .HasColumnType("decimal(18,2)");

            builder.Property(m => m.RentalDuration)
                   .HasColumnType("decimal(18,2)");
        }
    }
}
